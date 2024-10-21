using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class CompanyContactsCountAggregate
{
    public int Id { get; set; }

    public int? Name { get; set; }

    public int? Email { get; set; }

    public int? Phone { get; set; }

    public int? JobTitle { get; set; }

    public int? Timezone { get; set; }

    public int? Stage { get; set; }

    public int? Status { get; set; }

    public int? Score { get; set; }

    public int? CreatedAt { get; set; }

    public int? UpdatedAt { get; set; }
}
