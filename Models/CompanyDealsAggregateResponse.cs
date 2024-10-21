using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class CompanyDealsAggregateResponse
{
    public int? GroupById { get; set; }

    public string? GroupByTitle { get; set; }

    public double? GroupByValue { get; set; }

    public int? GroupByCloseDateYear { get; set; }

    public int? GroupByCloseDateMonth { get; set; }

    public int? GroupByCloseDateDay { get; set; }

    public int? GroupByStageId { get; set; }

    public int? GroupByDealOwnerId { get; set; }

    public int? GroupByCompanyId { get; set; }

    public DateTime? GroupByCreatedAt { get; set; }

    public DateTime? GroupByUpdatedAt { get; set; }

    public int? CountId { get; set; }

    public int? CountTitle { get; set; }

    public int? CountValue { get; set; }

    public int? CountCloseDateYear { get; set; }

    public int? CountCloseDateMonth { get; set; }

    public int? CountCloseDateDay { get; set; }

    public int? CountStageId { get; set; }

    public int? CountDealOwnerId { get; set; }

    public int? CountCompanyId { get; set; }

    public int? CountCreatedAt { get; set; }

    public int? CountUpdatedAt { get; set; }

    public double? SumId { get; set; }

    public double? SumValue { get; set; }

    public double? AvgId { get; set; }

    public double? AvgValue { get; set; }

    public int? MinId { get; set; }

    public int? MinTitle { get; set; }

    public int? MaxId { get; set; }

    public int? MaxTitle { get; set; }
}
