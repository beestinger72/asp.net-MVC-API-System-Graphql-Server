using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class DealStageDealsCountAggregate
{
    public int? Id { get; set; }

    public int? Title { get; set; }

    public int? Value { get; set; }

    public int? CloseDateYear { get; set; }

    public int? CloseDateMonth { get; set; }

    public int? CloseDateDay { get; set; }

    public int? StageId { get; set; }

    public int? DealOwnerId { get; set; }

    public int? CompanyId { get; set; }

    public int? CreatedAt { get; set; }

    public int? UpdatedAt { get; set; }
}
