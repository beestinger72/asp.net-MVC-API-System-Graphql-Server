using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class QuoteDeleteResponse
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public double? SubTotal { get; set; }

    public int? Tax { get; set; }

    public double? Total { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
