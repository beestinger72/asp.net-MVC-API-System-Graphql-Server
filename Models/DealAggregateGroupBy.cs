using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class DealAggregateGroupBy
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

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }
}
