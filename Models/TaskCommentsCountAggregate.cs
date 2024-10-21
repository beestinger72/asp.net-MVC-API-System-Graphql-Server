using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class TaskCommentsCountAggregate
{
    public int Id { get; set; }

    public int? CreatedAt { get; set; }

    public int? UpdatedAt { get; set; }
}
