using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? AvatarUrl { get; set; }

    public int? TotalRevenue { get; set; }

    public string? CompanySize { get; set; }

    public string? Industry { get; set; }

    public string? BusinessType { get; set; }

    public string? Country { get; set; }

    public string? Website { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? SalesOwner { get; set; }

    public virtual ICollection<CompanyNote> CompanyNotes { get; set; } = new List<CompanyNote>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<Deal> Deals { get; set; } = new List<Deal>();

    public virtual ICollection<Quote> Quotes { get; set; } = new List<Quote>();

    public virtual User? SalesOwnerNavigation { get; set; }

    public virtual User? UpdatedByNavigation { get; set; }
}
