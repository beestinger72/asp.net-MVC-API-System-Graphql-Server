using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class QuoteItem
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public double UnitPrice { get; set; }

    public int Quantity { get; set; }

    public int Discount { get; set; }

    public double TotalPrice { get; set; }
}
