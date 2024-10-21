using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class CompanyNotesCountAggregate
{
    public int Id { get; set; }

    public int? CreatedAtCount { get; set; }

    public int? UpdatedAtCount { get; set; }
}
