using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Audit
{
    public int Id { get; set; }

    public string Action { get; set; } = null!;

    public string TargetEntity { get; set; } = null!;

    public double TargetId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? UserId { get; set; }

    public virtual User? User { get; set; }
}
