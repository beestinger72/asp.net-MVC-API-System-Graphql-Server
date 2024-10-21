using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Contact
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public string? JobTitle { get; set; }

    public string? Timezone { get; set; }

    public string? AvatarUrl { get; set; }

    public string Stage { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int? Score { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string SalesOwner { get; set; } = null!;

    public int Company { get; set; }

    public virtual Company CompanyNavigation { get; set; } = null!;

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<Quote> Quotes { get; set; } = new List<Quote>();

    public virtual User SalesOwnerNavigation { get; set; } = null!;

    public virtual User? UpdatedByNavigation { get; set; }
}
