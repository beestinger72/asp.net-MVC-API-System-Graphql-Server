using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class CompanyNotesMinAggregate
{
    public int Id { get; set; }

    public DateTime? MinCreatedAt { get; set; }

    public DateTime? MinUpdatedAt { get; set; }
}
