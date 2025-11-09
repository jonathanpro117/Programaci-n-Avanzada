using System;
using System.Collections.Generic;
using EmpresaXYZ.Models;

namespace EmpresaXYZ.Data;

internal sealed class ServiceRepository
{
    public List<ServiceOrder> GetAll()
    {
        using var connection = Database.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = @"SELECT s.Id, s.CustomerId, c.Name, c.Email, s.Description, s.Price, s.ServiceDate, s.CreatedAt
                                FROM Services s
                                INNER JOIN Customers c ON c.Id = s.CustomerId
                                ORDER BY s.ServiceDate DESC;";

        using var reader = command.ExecuteReader();
        var services = new List<ServiceOrder>();

        while (reader.Read())
        {
            services.Add(new ServiceOrder
            {
                Id = reader.GetInt32(0),
                CustomerId = reader.GetInt32(1),
                CustomerName = $"{reader.GetString(2)} ({reader.GetString(3)})",
                Description = reader.GetString(4),
                Price = Convert.ToDecimal(reader.GetDouble(5)),
                ServiceDate = DateTime.Parse(reader.GetString(6)),
                CreatedAt = DateTime.Parse(reader.GetString(7))
            });
        }

        return services;
    }

    public int Insert(ServiceOrder service)
    {
        using var connection = Database.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = @"INSERT INTO Services (CustomerId, Description, Price, ServiceDate)
                                VALUES (@CustomerId, @Description, @Price, @ServiceDate);
                                SELECT last_insert_rowid();";
        command.Parameters.AddWithValue("@CustomerId", service.CustomerId);
        command.Parameters.AddWithValue("@Description", service.Description);
        command.Parameters.AddWithValue("@Price", Convert.ToDouble(service.Price));
        command.Parameters.AddWithValue("@ServiceDate", service.ServiceDate.ToString("yyyy-MM-dd"));

        var result = command.ExecuteScalar();
        return Convert.ToInt32(result);
    }

    public void Update(ServiceOrder service)
    {
        using var connection = Database.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = @"UPDATE Services SET CustomerId = @CustomerId, Description = @Description, Price = @Price, ServiceDate = @ServiceDate
                                WHERE Id = @Id;";
        command.Parameters.AddWithValue("@CustomerId", service.CustomerId);
        command.Parameters.AddWithValue("@Description", service.Description);
        command.Parameters.AddWithValue("@Price", Convert.ToDouble(service.Price));
        command.Parameters.AddWithValue("@ServiceDate", service.ServiceDate.ToString("yyyy-MM-dd"));
        command.Parameters.AddWithValue("@Id", service.Id);
        command.ExecuteNonQuery();
    }

    public void Delete(int serviceId)
    {
        using var connection = Database.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = @"DELETE FROM Services WHERE Id = @Id;";
        command.Parameters.AddWithValue("@Id", serviceId);
        command.ExecuteNonQuery();
    }
}
