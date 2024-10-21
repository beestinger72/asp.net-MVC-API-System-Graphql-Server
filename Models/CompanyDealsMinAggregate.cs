using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class CompanyDealsMinAggregate
{
    public int? Id { get; set; }

    public string? Title { get; set; }

    public double? Value { get; set; }

    public int? CloseDateYear { get; set; }

    public int? CloseDateMonth { get; set; }

    public int? CloseDateDay { get; set; }

    public int? StageId { get; set; }

    public int? DealOwnerId { get; set; }

    public int? CompanyId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
