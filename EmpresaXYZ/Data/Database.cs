using System.IO;
using Microsoft.Data.Sqlite;

namespace EmpresaXYZ.Data;

internal static class Database
{
    private const string DatabaseFileName = "empresa_xyz.db";

    private static readonly string DatabasePath = Path.Combine(AppContext.BaseDirectory, DatabaseFileName);

    public static string ConnectionString
    {
        get
        {
            var builder = new SqliteConnectionStringBuilder
            {
                DataSource = DatabasePath,
                Mode = SqliteOpenMode.ReadWriteCreate
            };
            return builder.ToString();
        }
    }

    public static SqliteConnection OpenConnection()
    {
        var connection = new SqliteConnection(ConnectionString);
        connection.Open();

        using var pragma = connection.CreateCommand();
        pragma.CommandText = "PRAGMA foreign_keys = ON;";
        pragma.ExecuteNonQuery();

        return connection;
    }
}
