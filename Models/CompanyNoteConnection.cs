using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class CompanyNoteConnection
{
    public int Id { get; set; }

    public int? PageInfoOffset { get; set; }

    public int? PageInfoLimit { get; set; }

    public bool? PageInfoHasNextPage { get; set; }

    public string? Nodes { get; set; }

    public int? TotalCount { get; set; }
}
