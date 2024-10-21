using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class TaskCommentsMaxAggregate
{
    public int Id { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
