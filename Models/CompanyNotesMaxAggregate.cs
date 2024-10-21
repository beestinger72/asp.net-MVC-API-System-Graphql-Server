using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class CompanyNotesMaxAggregate
{
    public int Id { get; set; }

    public DateTime? MaxCreatedAt { get; set; }

    public DateTime? MaxUpdatedAt { get; set; }
}
