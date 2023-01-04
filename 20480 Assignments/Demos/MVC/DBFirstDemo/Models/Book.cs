using System;
using System.Collections.Generic;

namespace DBFirstDemo.Models;

public partial class Book
{
    public decimal BookId { get; set; }

    public string BookName { get; set; } = null!;

    public string? Author { get; set; }
}
