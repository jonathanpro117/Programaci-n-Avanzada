namespace EmpresaXYZ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null!;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.lblCustomerSummary = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.colCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.lblCustomerSearch = new System.Windows.Forms.Label();
            this.grpCustomerForm = new System.Windows.Forms.GroupBox();
            this.btnClearCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.lblServiceSummary = new System.Windows.Forms.Label();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.colServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpServiceForm = new System.Windows.Forms.GroupBox();
            this.btnClearService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.nudServicePrice = new System.Windows.Forms.NumericUpDown();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.cboServiceCustomer = new System.Windows.Forms.ComboBox();
            this.lblServiceCustomer = new System.Windows.Forms.Label();
            this.chkServiceDateRange = new System.Windows.Forms.CheckBox();
            this.lblServiceFilterFrom = new System.Windows.Forms.Label();
            this.dtpServiceFilterFrom = new System.Windows.Forms.DateTimePicker();
            this.lblServiceFilterTo = new System.Windows.Forms.Label();
            this.dtpServiceFilterTo = new System.Windows.Forms.DateTimePicker();
            this.btnExportServices = new System.Windows.Forms.Button();
            this.cboFilterCustomer = new System.Windows.Forms.ComboBox();
            this.lblFilterCustomer = new System.Windows.Forms.Label();
            this.txtServiceSearch = new System.Windows.Forms.TextBox();
            this.lblServiceSearch = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.grpCustomerForm.SuspendLayout();
            this.tabServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.grpServiceForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabCustomers);
            this.tabMain.Controls.Add(this.tabServices);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(936, 586);
            this.tabMain.TabIndex = 0;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.lblCustomerSummary);
            this.tabCustomers.Controls.Add(this.dgvCustomers);
            this.tabCustomers.Controls.Add(this.txtCustomerSearch);
            this.tabCustomers.Controls.Add(this.lblCustomerSearch);
            this.tabCustomers.Controls.Add(this.grpCustomerForm);
            this.tabCustomers.Location = new System.Drawing.Point(4, 29);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(928, 553);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "Clientes";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // lblCustomerSummary
            // 
            this.lblCustomerSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCustomerSummary.AutoSize = true;
            this.lblCustomerSummary.Location = new System.Drawing.Point(18, 518);
            this.lblCustomerSummary.Name = "lblCustomerSummary";
            this.lblCustomerSummary.Size = new System.Drawing.Size(164, 20);
            this.lblCustomerSummary.TabIndex = 4;
            this.lblCustomerSummary.Text = "Clientes mostrados: 0";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerId,
            this.colCustomerName,
            this.colCustomerEmail,
            this.colCustomerPhone,
            this.colCustomerCreated});
            this.dgvCustomers.Location = new System.Drawing.Point(18, 236);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowTemplate.Height = 29;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(892, 269);
            this.dgvCustomers.TabIndex = 3;
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.dgvCustomers_SelectionChanged);
            // 
            // colCustomerId
            // 
            this.colCustomerId.DataPropertyName = "Id";
            this.colCustomerId.FillWeight = 40F;
            this.colCustomerId.HeaderText = "ID";
            this.colCustomerId.MinimumWidth = 6;
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.ReadOnly = true;
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "Name";
            this.colCustomerName.HeaderText = "Nombre";
            this.colCustomerName.MinimumWidth = 6;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colCustomerEmail
            // 
            this.colCustomerEmail.DataPropertyName = "Email";
            this.colCustomerEmail.HeaderText = "Correo";
            this.colCustomerEmail.MinimumWidth = 6;
            this.colCustomerEmail.Name = "colCustomerEmail";
            this.colCustomerEmail.ReadOnly = true;
            // 
            // colCustomerPhone
            // 
            this.colCustomerPhone.DataPropertyName = "Phone";
            this.colCustomerPhone.HeaderText = "Teléfono";
            this.colCustomerPhone.MinimumWidth = 6;
            this.colCustomerPhone.Name = "colCustomerPhone";
            this.colCustomerPhone.ReadOnly = true;
            // 
            // colCustomerCreated
            // 
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.colCustomerCreated.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCustomerCreated.DataPropertyName = "CreatedAt";
            this.colCustomerCreated.HeaderText = "Fecha de registro";
            this.colCustomerCreated.MinimumWidth = 6;
            this.colCustomerCreated.Name = "colCustomerCreated";
            this.colCustomerCreated.ReadOnly = true;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerSearch.Location = new System.Drawing.Point(411, 49);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.PlaceholderText = "Buscar por nombre, correo o teléfono";
            this.txtCustomerSearch.Size = new System.Drawing.Size(499, 27);
            this.txtCustomerSearch.TabIndex = 2;
            this.txtCustomerSearch.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            // 
            // lblCustomerSearch
            // 
            this.lblCustomerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerSearch.AutoSize = true;
            this.lblCustomerSearch.Location = new System.Drawing.Point(411, 26);
            this.lblCustomerSearch.Name = "lblCustomerSearch";
            this.lblCustomerSearch.Size = new System.Drawing.Size(160, 20);
            this.lblCustomerSearch.TabIndex = 1;
            this.lblCustomerSearch.Text = "Buscar clientes (filtro)";
            // 
            // grpCustomerForm
            // 
            this.grpCustomerForm.Controls.Add(this.btnClearCustomer);
            this.grpCustomerForm.Controls.Add(this.btnDeleteCustomer);
            this.grpCustomerForm.Controls.Add(this.btnUpdateCustomer);
            this.grpCustomerForm.Controls.Add(this.btnAddCustomer);
            this.grpCustomerForm.Controls.Add(this.txtCustomerPhone);
            this.grpCustomerForm.Controls.Add(this.lblCustomerPhone);
            this.grpCustomerForm.Controls.Add(this.txtCustomerEmail);
            this.grpCustomerForm.Controls.Add(this.lblCustomerEmail);
            this.grpCustomerForm.Controls.Add(this.txtCustomerName);
            this.grpCustomerForm.Controls.Add(this.lblCustomerName);
            this.grpCustomerForm.Location = new System.Drawing.Point(18, 18);
            this.grpCustomerForm.Name = "grpCustomerForm";
            this.grpCustomerForm.Size = new System.Drawing.Size(360, 200);
            this.grpCustomerForm.TabIndex = 0;
            this.grpCustomerForm.TabStop = false;
            this.grpCustomerForm.Text = "Datos del cliente";
            // 
            // btnClearCustomer
            // 
            this.btnClearCustomer.Location = new System.Drawing.Point(268, 155);
            this.btnClearCustomer.Name = "btnClearCustomer";
            this.btnClearCustomer.Size = new System.Drawing.Size(75, 29);
            this.btnClearCustomer.TabIndex = 9;
            this.btnClearCustomer.Text = "Limpiar";
            this.btnClearCustomer.UseVisualStyleBackColor = true;
            this.btnClearCustomer.Click += new System.EventHandler(this.btnClearCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(187, 155);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 29);
            this.btnDeleteCustomer.TabIndex = 8;
            this.btnDeleteCustomer.Text = "Eliminar";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(106, 155);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 29);
            this.btnUpdateCustomer.TabIndex = 7;
            this.btnUpdateCustomer.Text = "Actualizar";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(25, 155);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 29);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Agregar";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(25, 122);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(318, 27);
            this.txtCustomerPhone.TabIndex = 5;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(21, 99);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(67, 20);
            this.lblCustomerPhone.TabIndex = 4;
            this.lblCustomerPhone.Text = "Teléfono";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(25, 69);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(318, 27);
            this.txtCustomerEmail.TabIndex = 3;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(21, 46);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(138, 20);
            this.lblCustomerEmail.TabIndex = 2;
            this.lblCustomerEmail.Text = "Correo electrónico";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(25, 39);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(318, 27);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(21, 16);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(58, 20);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Nombre";
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.lblServiceSummary);
            this.tabServices.Controls.Add(this.dgvServices);
            this.tabServices.Controls.Add(this.grpServiceForm);
            this.tabServices.Controls.Add(this.btnExportServices);
            this.tabServices.Controls.Add(this.dtpServiceFilterTo);
            this.tabServices.Controls.Add(this.lblServiceFilterTo);
            this.tabServices.Controls.Add(this.dtpServiceFilterFrom);
            this.tabServices.Controls.Add(this.lblServiceFilterFrom);
            this.tabServices.Controls.Add(this.chkServiceDateRange);
            this.tabServices.Controls.Add(this.cboFilterCustomer);
            this.tabServices.Controls.Add(this.lblFilterCustomer);
            this.tabServices.Controls.Add(this.txtServiceSearch);
            this.tabServices.Controls.Add(this.lblServiceSearch);
            this.tabServices.Location = new System.Drawing.Point(4, 29);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(928, 553);
            this.tabServices.TabIndex = 1;
            this.tabServices.Text = "Servicios";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // lblServiceSummary
            // 
            this.lblServiceSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblServiceSummary.AutoSize = true;
            this.lblServiceSummary.Location = new System.Drawing.Point(18, 518);
            this.lblServiceSummary.Name = "lblServiceSummary";
            this.lblServiceSummary.Size = new System.Drawing.Size(171, 20);
            this.lblServiceSummary.TabIndex = 6;
            this.lblServiceSummary.Text = "Servicios mostrados: 0";
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServiceId,
            this.colServiceCustomer,
            this.colServiceDescription,
            this.colServicePrice,
            this.colServiceDate});
            this.dgvServices.Location = new System.Drawing.Point(18, 249);
            this.dgvServices.MultiSelect = false;
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.RowTemplate.Height = 29;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(892, 256);
            this.dgvServices.TabIndex = 5;
            this.dgvServices.SelectionChanged += new System.EventHandler(this.dgvServices_SelectionChanged);
            // 
            // colServiceId
            // 
            this.colServiceId.DataPropertyName = "Id";
            this.colServiceId.FillWeight = 40F;
            this.colServiceId.HeaderText = "ID";
            this.colServiceId.MinimumWidth = 6;
            this.colServiceId.Name = "colServiceId";
            this.colServiceId.ReadOnly = true;
            // 
            // colServiceCustomer
            // 
            this.colServiceCustomer.DataPropertyName = "CustomerName";
            this.colServiceCustomer.HeaderText = "Cliente";
            this.colServiceCustomer.MinimumWidth = 6;
            this.colServiceCustomer.Name = "colServiceCustomer";
            this.colServiceCustomer.ReadOnly = true;
            // 
            // colServiceDescription
            // 
            this.colServiceDescription.DataPropertyName = "Description";
            this.colServiceDescription.HeaderText = "Descripción";
            this.colServiceDescription.MinimumWidth = 6;
            this.colServiceDescription.Name = "colServiceDescription";
            this.colServiceDescription.ReadOnly = true;
            // 
            // colServicePrice
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.colServicePrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.colServicePrice.DataPropertyName = "Price";
            this.colServicePrice.HeaderText = "Precio";
            this.colServicePrice.MinimumWidth = 6;
            this.colServicePrice.Name = "colServicePrice";
            this.colServicePrice.ReadOnly = true;
            // 
            // colServiceDate
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.colServiceDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colServiceDate.DataPropertyName = "ServiceDate";
            this.colServiceDate.HeaderText = "Fecha del servicio";
            this.colServiceDate.MinimumWidth = 6;
            this.colServiceDate.Name = "colServiceDate";
            this.colServiceDate.ReadOnly = true;
            // 
            // grpServiceForm
            // 
            this.grpServiceForm.Controls.Add(this.dtpServiceDate);
            this.grpServiceForm.Controls.Add(this.lblServiceDate);
            this.grpServiceForm.Controls.Add(this.nudServicePrice);
            this.grpServiceForm.Controls.Add(this.lblServicePrice);
            this.grpServiceForm.Controls.Add(this.txtServiceDescription);
            this.grpServiceForm.Controls.Add(this.lblServiceDescription);
            this.grpServiceForm.Controls.Add(this.cboServiceCustomer);
            this.grpServiceForm.Controls.Add(this.lblServiceCustomer);
            this.grpServiceForm.Controls.Add(this.btnClearService);
            this.grpServiceForm.Controls.Add(this.btnDeleteService);
            this.grpServiceForm.Controls.Add(this.btnUpdateService);
            this.grpServiceForm.Controls.Add(this.btnAddService);
            this.grpServiceForm.Location = new System.Drawing.Point(18, 18);
            this.grpServiceForm.Name = "grpServiceForm";
            this.grpServiceForm.Size = new System.Drawing.Size(360, 225);
            this.grpServiceForm.TabIndex = 0;
            this.grpServiceForm.TabStop = false;
            this.grpServiceForm.Text = "Datos del servicio";
            // 
            // btnClearService
            // 
            this.btnClearService.Location = new System.Drawing.Point(268, 197);
            this.btnClearService.Name = "btnClearService";
            this.btnClearService.Size = new System.Drawing.Size(75, 29);
            this.btnClearService.TabIndex = 11;
            this.btnClearService.Text = "Limpiar";
            this.btnClearService.UseVisualStyleBackColor = true;
            this.btnClearService.Click += new System.EventHandler(this.btnClearService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(187, 197);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(75, 29);
            this.btnDeleteService.TabIndex = 10;
            this.btnDeleteService.Text = "Eliminar";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(106, 197);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(75, 29);
            this.btnUpdateService.TabIndex = 9;
            this.btnUpdateService.Text = "Actualizar";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(25, 197);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(75, 29);
            this.btnAddService.TabIndex = 8;
            this.btnAddService.Text = "Agregar";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpServiceDate.Location = new System.Drawing.Point(189, 160);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(154, 27);
            this.dtpServiceDate.TabIndex = 7;
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.Location = new System.Drawing.Point(185, 137);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(118, 20);
            this.lblServiceDate.TabIndex = 6;
            this.lblServiceDate.Text = "Fecha del servicio";
            // 
            // nudServicePrice
            // 
            this.nudServicePrice.DecimalPlaces = 2;
            this.nudServicePrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudServicePrice.Location = new System.Drawing.Point(25, 160);
            this.nudServicePrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudServicePrice.Name = "nudServicePrice";
            this.nudServicePrice.Size = new System.Drawing.Size(150, 27);
            this.nudServicePrice.TabIndex = 5;
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Location = new System.Drawing.Point(21, 137);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(48, 20);
            this.lblServicePrice.TabIndex = 4;
            this.lblServicePrice.Text = "Precio";
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Location = new System.Drawing.Point(25, 105);
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.Size = new System.Drawing.Size(318, 27);
            this.txtServiceDescription.TabIndex = 3;
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.Location = new System.Drawing.Point(21, 82);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(83, 20);
            this.lblServiceDescription.TabIndex = 2;
            this.lblServiceDescription.Text = "Descripción";
            // 
            // cboServiceCustomer
            // 
            this.cboServiceCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServiceCustomer.FormattingEnabled = true;
            this.cboServiceCustomer.Location = new System.Drawing.Point(25, 44);
            this.cboServiceCustomer.Name = "cboServiceCustomer";
            this.cboServiceCustomer.Size = new System.Drawing.Size(318, 28);
            this.cboServiceCustomer.TabIndex = 1;
            // 
            // lblServiceCustomer
            // 
            this.lblServiceCustomer.AutoSize = true;
            this.lblServiceCustomer.Location = new System.Drawing.Point(21, 21);
            this.lblServiceCustomer.Name = "lblServiceCustomer";
            this.lblServiceCustomer.Size = new System.Drawing.Size(57, 20);
            this.lblServiceCustomer.TabIndex = 0;
            this.lblServiceCustomer.Text = "Cliente";
            // 
            // chkServiceDateRange
            //
            this.chkServiceDateRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkServiceDateRange.AutoSize = true;
            this.chkServiceDateRange.Location = new System.Drawing.Point(411, 80);
            this.chkServiceDateRange.Name = "chkServiceDateRange";
            this.chkServiceDateRange.Size = new System.Drawing.Size(156, 24);
            this.chkServiceDateRange.TabIndex = 3;
            this.chkServiceDateRange.Text = "Filtrar por fechas";
            this.chkServiceDateRange.UseVisualStyleBackColor = true;
            this.chkServiceDateRange.CheckedChanged += new System.EventHandler(this.chkServiceDateRange_CheckedChanged);
            //
            // lblServiceFilterFrom
            //
            this.lblServiceFilterFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceFilterFrom.AutoSize = true;
            this.lblServiceFilterFrom.Location = new System.Drawing.Point(411, 109);
            this.lblServiceFilterFrom.Name = "lblServiceFilterFrom";
            this.lblServiceFilterFrom.Size = new System.Drawing.Size(53, 20);
            this.lblServiceFilterFrom.TabIndex = 4;
            this.lblServiceFilterFrom.Text = "Desde";
            //
            // dtpServiceFilterFrom
            //
            this.dtpServiceFilterFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpServiceFilterFrom.Enabled = false;
            this.dtpServiceFilterFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpServiceFilterFrom.Location = new System.Drawing.Point(470, 104);
            this.dtpServiceFilterFrom.Name = "dtpServiceFilterFrom";
            this.dtpServiceFilterFrom.Size = new System.Drawing.Size(150, 27);
            this.dtpServiceFilterFrom.TabIndex = 5;
            this.dtpServiceFilterFrom.ValueChanged += new System.EventHandler(this.dtpServiceFilterFrom_ValueChanged);
            //
            // lblServiceFilterTo
            //
            this.lblServiceFilterTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceFilterTo.AutoSize = true;
            this.lblServiceFilterTo.Location = new System.Drawing.Point(641, 109);
            this.lblServiceFilterTo.Name = "lblServiceFilterTo";
            this.lblServiceFilterTo.Size = new System.Drawing.Size(46, 20);
            this.lblServiceFilterTo.TabIndex = 6;
            this.lblServiceFilterTo.Text = "Hasta";
            //
            // dtpServiceFilterTo
            //
            this.dtpServiceFilterTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpServiceFilterTo.Enabled = false;
            this.dtpServiceFilterTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpServiceFilterTo.Location = new System.Drawing.Point(693, 104);
            this.dtpServiceFilterTo.Name = "dtpServiceFilterTo";
            this.dtpServiceFilterTo.Size = new System.Drawing.Size(217, 27);
            this.dtpServiceFilterTo.TabIndex = 7;
            this.dtpServiceFilterTo.ValueChanged += new System.EventHandler(this.dtpServiceFilterTo_ValueChanged);
            //
            // lblFilterCustomer
            //
            this.lblFilterCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterCustomer.AutoSize = true;
            this.lblFilterCustomer.Location = new System.Drawing.Point(411, 156);
            this.lblFilterCustomer.Name = "lblFilterCustomer";
            this.lblFilterCustomer.Size = new System.Drawing.Size(150, 20);
            this.lblFilterCustomer.TabIndex = 8;
            this.lblFilterCustomer.Text = "Filtrar por cliente";
            //
            // cboFilterCustomer
            //
            this.cboFilterCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFilterCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterCustomer.FormattingEnabled = true;
            this.cboFilterCustomer.Location = new System.Drawing.Point(411, 179);
            this.cboFilterCustomer.Name = "cboFilterCustomer";
            this.cboFilterCustomer.Size = new System.Drawing.Size(499, 28);
            this.cboFilterCustomer.TabIndex = 9;
            this.cboFilterCustomer.SelectedIndexChanged += new System.EventHandler(this.cboFilterCustomer_SelectedIndexChanged);
            //
            // btnExportServices
            //
            this.btnExportServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportServices.Location = new System.Drawing.Point(411, 213);
            this.btnExportServices.Name = "btnExportServices";
            this.btnExportServices.Size = new System.Drawing.Size(499, 29);
            this.btnExportServices.TabIndex = 10;
            this.btnExportServices.Text = "Exportar servicios a CSV";
            this.btnExportServices.UseVisualStyleBackColor = true;
            this.btnExportServices.Click += new System.EventHandler(this.btnExportServices_Click);
            //
            // txtServiceSearch
            //
            this.txtServiceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServiceSearch.Location = new System.Drawing.Point(411, 40);
            this.txtServiceSearch.Name = "txtServiceSearch";
            this.txtServiceSearch.PlaceholderText = "Buscar por descripción";
            this.txtServiceSearch.Size = new System.Drawing.Size(499, 27);
            this.txtServiceSearch.TabIndex = 2;
            this.txtServiceSearch.TextChanged += new System.EventHandler(this.txtServiceSearch_TextChanged);
            // 
            // lblServiceSearch
            // 
            this.lblServiceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceSearch.AutoSize = true;
            this.lblServiceSearch.Location = new System.Drawing.Point(411, 17);
            this.lblServiceSearch.Name = "lblServiceSearch";
            this.lblServiceSearch.Size = new System.Drawing.Size(141, 20);
            this.lblServiceSearch.TabIndex = 1;
            this.lblServiceSearch.Text = "Buscar servicios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 610);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Empresarial XYZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.grpCustomerForm.ResumeLayout(false);
            this.grpCustomerForm.PerformLayout();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.grpServiceForm.ResumeLayout(false);
            this.grpServiceForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicePrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.GroupBox grpCustomerForm;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnClearCustomer;
        private System.Windows.Forms.Label lblCustomerSearch;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblCustomerSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerCreated;
        private System.Windows.Forms.GroupBox grpServiceForm;
        private System.Windows.Forms.ComboBox cboServiceCustomer;
        private System.Windows.Forms.Label lblServiceCustomer;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.NumericUpDown nudServicePrice;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnClearService;
        private System.Windows.Forms.CheckBox chkServiceDateRange;
        private System.Windows.Forms.Label lblServiceFilterFrom;
        private System.Windows.Forms.DateTimePicker dtpServiceFilterFrom;
        private System.Windows.Forms.Label lblServiceFilterTo;
        private System.Windows.Forms.DateTimePicker dtpServiceFilterTo;
        private System.Windows.Forms.Button btnExportServices;
        private System.Windows.Forms.TextBox txtServiceSearch;
        private System.Windows.Forms.Label lblServiceSearch;
        private System.Windows.Forms.ComboBox cboFilterCustomer;
        private System.Windows.Forms.Label lblFilterCustomer;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServicePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceDate;
        private System.Windows.Forms.Label lblServiceSummary;
    }
}
