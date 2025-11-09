using System;
using Microsoft.Data.Sqlite;

namespace EmpresaXYZ.Data;

internal static class DatabaseInitializer
{
    public static void Initialize()
    {
        using var connection = Database.OpenConnection();
        using var transaction = connection.BeginTransaction();

        CreateSchema(connection, transaction);
        SeedData(connection, transaction);

        transaction.Commit();
    }

    private static void CreateSchema(SqliteConnection connection, SqliteTransaction transaction)
    {
        var commands = new[]
        {
            @"CREATE TABLE IF NOT EXISTS Customers (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Email TEXT NOT NULL UNIQUE,
                    Phone TEXT NOT NULL,
                    CreatedAt TEXT NOT NULL DEFAULT (CURRENT_TIMESTAMP)
                );",
            @"CREATE TABLE IF NOT EXISTS Services (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    CustomerId INTEGER NOT NULL,
                    Description TEXT NOT NULL,
                    Price REAL NOT NULL,
                    ServiceDate TEXT NOT NULL,
                    CreatedAt TEXT NOT NULL DEFAULT (CURRENT_TIMESTAMP),
                    FOREIGN KEY(CustomerId) REFERENCES Customers(Id) ON DELETE RESTRICT ON UPDATE CASCADE
                );",
            "CREATE INDEX IF NOT EXISTS IX_Customers_Name ON Customers(Name);",
            "CREATE INDEX IF NOT EXISTS IX_Services_CustomerId ON Services(CustomerId);"
        };

        foreach (var sql in commands)
        {
            using var command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = sql;
            command.ExecuteNonQuery();
        }
    }

    private static void SeedData(SqliteConnection connection, SqliteTransaction transaction)
    {
        using var countCommand = connection.CreateCommand();
        countCommand.Transaction = transaction;
        countCommand.CommandText = "SELECT COUNT(*) FROM Customers;";
        var customerCount = (long)(countCommand.ExecuteScalar() ?? 0L);

        if (customerCount > 0)
        {
            return;
        }

        var customers = new (string Name, string Email, string Phone)[]
        {
            ("Ana García", "ana.garcia@xyz.com", "+34 600 123 456"),
            ("Carlos Pérez", "carlos.perez@xyz.com", "+34 611 987 654"),
            ("María López", "maria.lopez@xyz.com", "+34 622 456 789")
        };

        foreach (var (name, email, phone) in customers)
        {
            using var insert = connection.CreateCommand();
            insert.Transaction = transaction;
            insert.CommandText = @"INSERT INTO Customers (Name, Email, Phone) VALUES (@Name, @Email, @Phone);";
            insert.Parameters.AddWithValue("@Name", name);
            insert.Parameters.AddWithValue("@Email", email);
            insert.Parameters.AddWithValue("@Phone", phone);
            insert.ExecuteNonQuery();
        }

        var services = new (int CustomerId, string Description, decimal Price, DateTime ServiceDate)[]
        {
            (1, "Implementación de CRM", 5_375_000m, DateTime.Today.AddDays(-15)),
            (2, "Capacitación de personal", 2_064_000m, DateTime.Today.AddDays(-7)),
            (3, "Consultoría estratégica", 3_827_000m, DateTime.Today.AddDays(10))
        };

        foreach (var (customerId, description, price, serviceDate) in services)
        {
            using var insert = connection.CreateCommand();
            insert.Transaction = transaction;
            insert.CommandText = @"INSERT INTO Services (CustomerId, Description, Price, ServiceDate) VALUES (@CustomerId, @Description, @Price, @ServiceDate);";
            insert.Parameters.AddWithValue("@CustomerId", customerId);
            insert.Parameters.AddWithValue("@Description", description);
            insert.Parameters.AddWithValue("@Price", Convert.ToDouble(price));
            insert.Parameters.AddWithValue("@ServiceDate", serviceDate.ToString("yyyy-MM-dd"));
            insert.ExecuteNonQuery();
        }
    }
}
