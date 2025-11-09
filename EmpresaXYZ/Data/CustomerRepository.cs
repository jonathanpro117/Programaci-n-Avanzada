using System;
using System.Collections.Generic;
using EmpresaXYZ.Models;

namespace EmpresaXYZ.Data;

internal sealed class CustomerRepository
{
    public List<Customer> GetAll()
    {
        using var connection = Database.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = @"SELECT Id, Name, Email, Phone, CreatedAt FROM Customers ORDER BY Name;";

        using var reader = command.ExecuteReader();
        var customers = new List<Customer>();

        while (reader.Read())
        {
            customers.Add(new Customer
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Email = reader.GetString(2),
                Phone = reader.GetString(3),
                CreatedAt = DateTime.Parse(reader.GetString(4))
            });
        }

        return customers;
    }

    public int Insert(Customer customer)
    {
        using var connection = Database.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = @"INSERT INTO Customers (Name, Email, Phone) VALUES (@Name, @Email, @Phone); SELECT last_insert_rowid();";
        command.Parameters.AddWithValue("@Name", customer.Name);
        command.Parameters.AddWithValue("@Email", customer.Email);
        command.Parameters.AddWithValue("@Phone", customer.Phone);

        var result = command.ExecuteScalar();
        return Convert.ToInt32(result);
    }

    public void Update(Customer customer)
    {
        using var connection = Database.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = @"UPDATE Customers SET Name = @Name, Email = @Email, Phone = @Phone WHERE Id = @Id;";
        command.Parameters.AddWithValue("@Name", customer.Name);
        command.Parameters.AddWithValue("@Email", customer.Email);
        command.Parameters.AddWithValue("@Phone", customer.Phone);
        command.Parameters.AddWithValue("@Id", customer.Id);
        command.ExecuteNonQuery();
    }

    public void Delete(int customerId)
    {
        using var connection = Database.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = @"DELETE FROM Customers WHERE Id = @Id;";
        command.Parameters.AddWithValue("@Id", customerId);
        command.ExecuteNonQuery();
    }
}
