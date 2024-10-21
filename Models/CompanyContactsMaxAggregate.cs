using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class CompanyContactsMaxAggregate
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? JobTitle { get; set; }

    public string? Timezone { get; set; }

    public string? Stage { get; set; }

    public string? Status { get; set; }

    public int? Score { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
