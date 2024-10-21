using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class CompanyMinAggregate
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? TotalRevenue { get; set; }

    public string? CompanySize { get; set; }

    public string? Industry { get; set; }

    public string? BusinessType { get; set; }

    public string? Country { get; set; }

    public string? Website { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
