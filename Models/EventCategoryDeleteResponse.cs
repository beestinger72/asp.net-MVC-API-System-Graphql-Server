using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EventCategoryDeleteResponse
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
