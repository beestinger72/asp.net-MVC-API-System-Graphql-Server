using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class CompanyNotesAggregateResponse
{
    public int GroupById { get; set; }

    public DateTime? GroupByCreatedAt { get; set; }

    public DateTime? GroupByUpdatedAt { get; set; }

    public int? Count { get; set; }

    public int? Sum { get; set; }

    public double? Avg { get; set; }

    public int? Min { get; set; }

    public int? Max { get; set; }

    public virtual CompanyNotesAggregateGroupBy GroupBy { get; set; } = null!;
}
