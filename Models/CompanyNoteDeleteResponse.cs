using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class CompanyNoteDeleteResponse
{
    public int Id { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
