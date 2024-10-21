using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class DealStageDealsSumAggregate
{
    public double? Id { get; set; }

    public double? Value { get; set; }

    public double? CloseDateYear { get; set; }

    public double? CloseDateMonth { get; set; }

    public double? CloseDateDay { get; set; }

    public double? StageId { get; set; }

    public double? DealOwnerId { get; set; }

    public double? CompanyId { get; set; }
}
