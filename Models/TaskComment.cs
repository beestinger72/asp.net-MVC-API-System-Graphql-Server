using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class TaskComment
{
    public int Id { get; set; }

    public string Comment { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public int TaskId { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Task Task { get; set; } = null!;

    public virtual User? UpdatedByNavigation { get; set; }
}
