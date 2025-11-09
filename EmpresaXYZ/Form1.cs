using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using EmpresaXYZ.Data;
using EmpresaXYZ.Models;

namespace EmpresaXYZ;

public partial class Form1 : Form
{
    private readonly CustomerRepository _customerRepository = new();
    private readonly ServiceRepository _serviceRepository = new();

    private readonly BindingList<Customer> _customersBinding = new();
    private readonly BindingList<ServiceOrder> _servicesBinding = new();

    private List<Customer> _customers = new();
    private List<ServiceOrder> _services = new();
    private List<ServiceOrder> _filteredServices = new();

    private Customer? _selectedCustomer;
    private ServiceOrder? _selectedService;
    private bool _suppressServiceFilter;

    public Form1()
    {
        InitializeComponent();

        dgvCustomers.AutoGenerateColumns = false;
        dgvServices.AutoGenerateColumns = false;

        cboServiceCustomer.DisplayMember = nameof(ComboOption.Description);
        cboServiceCustomer.ValueMember = nameof(ComboOption.Id);
        cboFilterCustomer.DisplayMember = nameof(ComboOption.Description);
        cboFilterCustomer.ValueMember = nameof(ComboOption.Id);

        dgvCustomers.DataSource = _customersBinding;
        dgvServices.DataSource = _servicesBinding;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        LoadCustomers();

        dtpServiceFilterFrom.Value = DateTime.Today.AddMonths(-1);
        dtpServiceFilterTo.Value = DateTime.Today;

        LoadServices();
    }

    private void LoadCustomers()
    {
        _customers = _customerRepository.GetAll();
        ApplyCustomerFilter();
        PopulateCustomerSelectors();
    }

    private void LoadServices()
    {
        _services = _serviceRepository.GetAll();
        ApplyServiceFilter();
    }

    private void PopulateCustomerSelectors()
    {
        var selectedServiceCustomerId = (cboServiceCustomer.SelectedItem as ComboOption)?.Id ?? 0;
        var selectedFilterCustomerId = (cboFilterCustomer.SelectedItem as ComboOption)?.Id ?? 0;

        _suppressServiceFilter = true;

        var serviceOptions = _customers
            .Select(c => new ComboOption(c.Id, c.DisplayName))
            .ToList();

        cboServiceCustomer.DataSource = serviceOptions;
        if (serviceOptions.Count > 0)
        {
            var index = serviceOptions.FindIndex(option => option.Id == selectedServiceCustomerId);
            cboServiceCustomer.SelectedIndex = index >= 0 ? index : 0;
        }

        var filterOptions = new List<ComboOption> { new(0, "Todos los clientes") };
        filterOptions.AddRange(serviceOptions);
        cboFilterCustomer.DataSource = filterOptions;
        var filterIndex = filterOptions.FindIndex(option => option.Id == selectedFilterCustomerId);
        cboFilterCustomer.SelectedIndex = filterIndex >= 0 ? filterIndex : 0;

        _suppressServiceFilter = false;
        ApplyServiceFilter();
    }

    private void ApplyCustomerFilter()
    {
        var searchTerm = txtCustomerSearch.Text.Trim();

        IEnumerable<Customer> query = _customers;
        if (!string.IsNullOrEmpty(searchTerm))
        {
            query = query.Where(c => c.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
                                  || c.Email.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
                                  || c.Phone.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
        }

        var filtered = query.ToList();
        _customersBinding.Clear();
        foreach (var customer in filtered)
        {
            _customersBinding.Add(customer);
        }

        lblCustomerSummary.Text = $"Clientes mostrados: {filtered.Count} / {_customers.Count}";
        dgvCustomers.ClearSelection();
        ClearCustomerSelection();
    }

    private void ApplyServiceFilter()
    {
        if (_suppressServiceFilter)
        {
            return;
        }

        var selectedCustomerId = (cboFilterCustomer.SelectedItem as ComboOption)?.Id ?? 0;
        var searchTerm = txtServiceSearch.Text.Trim();

        IEnumerable<ServiceOrder> query = _services;
        if (selectedCustomerId > 0)
        {
            query = query.Where(s => s.CustomerId == selectedCustomerId);
        }

        if (!string.IsNullOrEmpty(searchTerm))
        {
            query = query.Where(s => s.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
        }

        if (chkServiceDateRange.Checked)
        {
            var (from, to) = GetServiceFilterRange();
            query = query.Where(s => s.ServiceDate.Date >= from && s.ServiceDate.Date <= to);
        }

        var filtered = query
            .OrderByDescending(s => s.ServiceDate)
            .ThenBy(s => s.Id)
            .ToList();

        _filteredServices = filtered;

        _servicesBinding.Clear();
        foreach (var service in filtered)
        {
            _servicesBinding.Add(service);
        }

        var totalAmount = filtered.Sum(s => s.Price);
        lblServiceSummary.Text = $"Servicios mostrados: {filtered.Count} / {_services.Count} | Importe total (COP): {totalAmount:C0}";
        dgvServices.ClearSelection();
        ClearServiceSelection();
    }

    private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
    {
        ApplyCustomerFilter();
    }

    private void txtServiceSearch_TextChanged(object sender, EventArgs e)
    {
        ApplyServiceFilter();
    }

    private void cboFilterCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        ApplyServiceFilter();
    }

    private void chkServiceDateRange_CheckedChanged(object sender, EventArgs e)
    {
        var enabled = chkServiceDateRange.Checked;
        dtpServiceFilterFrom.Enabled = enabled;
        dtpServiceFilterTo.Enabled = enabled;

        if (!enabled)
        {
            ApplyServiceFilter();
            return;
        }

        EnsureValidServiceFilterRange(true);
        ApplyServiceFilter();
    }

    private void dtpServiceFilterFrom_ValueChanged(object sender, EventArgs e)
    {
        if (!chkServiceDateRange.Checked)
        {
            return;
        }

        EnsureValidServiceFilterRange(true);
        ApplyServiceFilter();
    }

    private void dtpServiceFilterTo_ValueChanged(object sender, EventArgs e)
    {
        if (!chkServiceDateRange.Checked)
        {
            return;
        }

        EnsureValidServiceFilterRange(false);
        ApplyServiceFilter();
    }

    private void btnExportServices_Click(object sender, EventArgs e)
    {
        if (_filteredServices.Count == 0)
        {
            MessageBox.Show("No hay servicios para exportar con los filtros actuales.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var dialog = new SaveFileDialog
        {
            Title = "Exportar servicios a CSV",
            Filter = "Archivo CSV (*.csv)|*.csv",
            FileName = $"servicios_{DateTime.Now:yyyyMMdd_HHmm}.csv"
        };

        if (dialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            ExportServicesToCsv(dialog.FileName);
            MessageBox.Show("Servicios exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"No fue posible exportar los servicios. Detalle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvCustomers.CurrentRow?.DataBoundItem is Customer customer)
        {
            _selectedCustomer = customer;
            txtCustomerName.Text = customer.Name;
            txtCustomerEmail.Text = customer.Email;
            txtCustomerPhone.Text = customer.Phone;
        }
        else
        {
            ClearCustomerSelection();
        }
    }

    private void dgvServices_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvServices.CurrentRow?.DataBoundItem is ServiceOrder service)
        {
            _selectedService = service;
            cboServiceCustomer.SelectedValue = service.CustomerId;
            txtServiceDescription.Text = service.Description;
            nudServicePrice.Value = Math.Min(nudServicePrice.Maximum, Math.Max(nudServicePrice.Minimum, service.Price));
            dtpServiceDate.Value = service.ServiceDate;
        }
        else
        {
            ClearServiceSelection();
        }
    }

    private void btnAddCustomer_Click(object sender, EventArgs e)
    {
        if (!TryBuildCustomerFromForm(out var customer, out var errorMessage))
        {
            MessageBox.Show(errorMessage, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var newId = _customerRepository.Insert(customer);
            customer.Id = newId;
            _customers.Add(customer);
            LoadCustomers();
            LoadServices();
            ClearCustomerSelection();
            MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
        {
            MessageBox.Show("El correo electrónico ya está registrado para otro cliente.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"No fue posible registrar al cliente. Detalle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnUpdateCustomer_Click(object sender, EventArgs e)
    {
        if (_selectedCustomer is null)
        {
            MessageBox.Show("Seleccione un cliente a actualizar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!TryBuildCustomerFromForm(out var customer, out var errorMessage, _selectedCustomer.Id))
        {
            MessageBox.Show(errorMessage, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            _customerRepository.Update(customer);
            LoadCustomers();
            LoadServices();
            MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
        {
            MessageBox.Show("El correo electrónico ya está registrado para otro cliente.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"No fue posible actualizar al cliente. Detalle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnDeleteCustomer_Click(object sender, EventArgs e)
    {
        if (_selectedCustomer is null)
        {
            MessageBox.Show("Seleccione un cliente a eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirmation = MessageBox.Show("¿Desea eliminar el cliente seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (confirmation != DialogResult.Yes)
        {
            return;
        }

        try
        {
            _customerRepository.Delete(_selectedCustomer.Id);
            LoadCustomers();
            LoadServices();
            ClearCustomerSelection();
            MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
        {
            MessageBox.Show("No es posible eliminar el cliente porque tiene servicios asociados.", "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"No fue posible eliminar al cliente. Detalle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnClearCustomer_Click(object sender, EventArgs e)
    {
        ClearCustomerSelection();
        dgvCustomers.ClearSelection();
    }

    private void btnAddService_Click(object sender, EventArgs e)
    {
        if (!TryBuildServiceFromForm(out var service, out var errorMessage))
        {
            MessageBox.Show(errorMessage, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var newId = _serviceRepository.Insert(service);
            service.Id = newId;
            _services.Add(service);
            LoadServices();
            ClearServiceSelection();
            MessageBox.Show("Servicio registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"No fue posible registrar el servicio. Detalle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnUpdateService_Click(object sender, EventArgs e)
    {
        if (_selectedService is null)
        {
            MessageBox.Show("Seleccione un servicio a actualizar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!TryBuildServiceFromForm(out var service, out var errorMessage, _selectedService.Id))
        {
            MessageBox.Show(errorMessage, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            _serviceRepository.Update(service);
            LoadServices();
            MessageBox.Show("Servicio actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"No fue posible actualizar el servicio. Detalle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnDeleteService_Click(object sender, EventArgs e)
    {
        if (_selectedService is null)
        {
            MessageBox.Show("Seleccione un servicio a eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirmation = MessageBox.Show("¿Desea eliminar el servicio seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (confirmation != DialogResult.Yes)
        {
            return;
        }

        try
        {
            _serviceRepository.Delete(_selectedService.Id);
            LoadServices();
            ClearServiceSelection();
            MessageBox.Show("Servicio eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"No fue posible eliminar el servicio. Detalle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnClearService_Click(object sender, EventArgs e)
    {
        ClearServiceSelection();
        dgvServices.ClearSelection();
    }

    private bool TryBuildCustomerFromForm(out Customer customer, out string errorMessage, int? customerId = null)
    {
        customer = new Customer();
        errorMessage = string.Empty;

        var name = txtCustomerName.Text.Trim();
        var email = txtCustomerEmail.Text.Trim();
        var phone = txtCustomerPhone.Text.Trim();

        if (string.IsNullOrEmpty(name))
        {
            errorMessage = "El nombre es obligatorio.";
            return false;
        }

        if (name.Length < 3)
        {
            errorMessage = "El nombre debe contener al menos 3 caracteres.";
            return false;
        }

        if (string.IsNullOrEmpty(email))
        {
            errorMessage = "El correo electrónico es obligatorio.";
            return false;
        }

        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            errorMessage = "El correo electrónico no tiene un formato válido.";
            return false;
        }

        if (string.IsNullOrEmpty(phone))
        {
            errorMessage = "El teléfono es obligatorio.";
            return false;
        }

        var sanitizedPhone = Regex.Replace(phone, @"[\\s\-\(\)]", string.Empty);
        if (sanitizedPhone.StartsWith("+", StringComparison.Ordinal))
        {
            sanitizedPhone = sanitizedPhone[1..];
        }

        if (sanitizedPhone.StartsWith("57", StringComparison.Ordinal))
        {
            sanitizedPhone = sanitizedPhone[2..];
        }

        if (!Regex.IsMatch(sanitizedPhone, @"^(3\d{9}|60[1-9]\d{7})$"))
        {
            errorMessage = "Ingrese un teléfono colombiano válido (ejemplo: +57 310 123 4567).";
            return false;
        }

        customer = new Customer
        {
            Id = customerId ?? 0,
            Name = name,
            Email = email,
            Phone = phone
        };

        return true;
    }

    private bool TryBuildServiceFromForm(out ServiceOrder service, out string errorMessage, int? serviceId = null)
    {
        service = new ServiceOrder();
        errorMessage = string.Empty;

        if (cboServiceCustomer.SelectedItem is not ComboOption selectedCustomer || selectedCustomer.Id == 0)
        {
            errorMessage = "Seleccione el cliente asociado al servicio.";
            return false;
        }

        var description = txtServiceDescription.Text.Trim();
        if (string.IsNullOrEmpty(description))
        {
            errorMessage = "La descripción es obligatoria.";
            return false;
        }

        if (description.Length < 5)
        {
            errorMessage = "La descripción debe contener al menos 5 caracteres.";
            return false;
        }

        var price = nudServicePrice.Value;
        if (price <= 0)
        {
            errorMessage = "El precio debe ser mayor a cero.";
            return false;
        }

        var serviceDate = dtpServiceDate.Value.Date;

        service = new ServiceOrder
        {
            Id = serviceId ?? 0,
            CustomerId = selectedCustomer.Id,
            Description = description,
            Price = price,
            ServiceDate = serviceDate
        };

        return true;
    }

    private void EnsureValidServiceFilterRange(bool fromChanged)
    {
        var from = dtpServiceFilterFrom.Value.Date;
        var to = dtpServiceFilterTo.Value.Date;

        if (from <= to)
        {
            return;
        }

        if (fromChanged)
        {
            dtpServiceFilterTo.Value = from;
        }
        else
        {
            dtpServiceFilterFrom.Value = to;
        }
    }

    private (DateTime From, DateTime To) GetServiceFilterRange()
    {
        return (dtpServiceFilterFrom.Value.Date, dtpServiceFilterTo.Value.Date);
    }

    private void ExportServicesToCsv(string path)
    {
        var culture = CultureInfo.InvariantCulture;
        using var writer = new StreamWriter(path, false, new UTF8Encoding(true));
        writer.WriteLine("Cliente;Descripción;Precio;FechaServicio;Registrado");

        foreach (var service in _filteredServices)
        {
            var line = string.Join(';', new[]
            {
                EscapeCsvValue(service.CustomerName),
                EscapeCsvValue(service.Description),
                service.Price.ToString("F0", culture),
                service.ServiceDate.ToString("yyyy-MM-dd", culture),
                service.CreatedAt.ToString("yyyy-MM-dd HH:mm", culture)
            });

            writer.WriteLine(line);
        }
    }

    private static string EscapeCsvValue(string value)
    {
        if (value.Contains(';') || value.Contains('"') || value.Contains('\n') || value.Contains('\r'))
        {
            return $"\"{value.Replace("\"", "\"\"")}\"";
        }

        return value;
    }

    private void ClearCustomerSelection()
    {
        _selectedCustomer = null;
        txtCustomerName.Clear();
        txtCustomerEmail.Clear();
        txtCustomerPhone.Clear();
    }

    private void ClearServiceSelection()
    {
        _selectedService = null;
        txtServiceDescription.Clear();
        nudServicePrice.Value = 0;
        if (cboServiceCustomer.Items.Count > 0)
        {
            cboServiceCustomer.SelectedIndex = 0;
        }
        dtpServiceDate.Value = DateTime.Today;
    }

    private sealed record ComboOption(int Id, string Description);
}
