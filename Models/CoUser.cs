using System;
using System.Collections.Generic;

namespace ARD.Models;

public partial class CoUser
{
    public int Rowid { get; set; }

    public int? Time { get; set; }

    public string? User { get; set; }

    public string? Uuid { get; set; }
}
