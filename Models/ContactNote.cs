using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ContactNote
{
    public string Id { get; set; } = null!;

    public string Note { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? UpdatedById { get; set; }

    public string ContactId { get; set; } = null!;
}
