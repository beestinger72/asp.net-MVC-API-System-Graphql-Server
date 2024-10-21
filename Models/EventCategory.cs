using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EventCategory
{
    public string Id { get; set; } = null!;

    public string Title { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual User? UpdatedByNavigation { get; set; }
}
