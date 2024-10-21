using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class DeletedTaskComment
{
    public int Id { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }
}
