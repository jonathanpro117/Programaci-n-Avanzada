using System;

namespace EmpresaXYZ.Models;

internal sealed class ServiceOrder
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public DateTime ServiceDate { get; set; }

    public DateTime CreatedAt { get; set; }
        = DateTime.UtcNow;
}
