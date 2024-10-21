using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Quote
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Description { get; set; }

    public double SubTotal { get; set; }

    public int Tax { get; set; }

    public double Total { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string SalesOwner { get; set; } = null!;

    public int ContactId { get; set; }

    public int CompanyId { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Contact Contact { get; set; } = null!;

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User SalesOwnerNavigation { get; set; } = null!;

    public virtual User? UpdatedByNavigation { get; set; }
}
