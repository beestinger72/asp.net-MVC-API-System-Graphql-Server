using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Deal
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public double? Value { get; set; }

    public string Notes { get; set; } = null!;

    public int? CloseDateYear { get; set; }

    public int? CloseDateMonth { get; set; }

    public int? CloseDateDay { get; set; }

    public int? StageId { get; set; }

    public string DealOwnerId { get; set; } = null!;

    public int CompanyId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User DealOwner { get; set; } = null!;

    public virtual DealStage? Stage { get; set; }

    public virtual User? UpdatedByNavigation { get; set; }
}
