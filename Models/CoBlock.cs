using System;
using System.Collections.Generic;

namespace ARD.Models;

public partial class CoBlock
{
    public long Rowid { get; set; }

    public int? Time { get; set; }

    public int? User { get; set; }

    public int? Wid { get; set; }

    public int? X { get; set; }

    public int? Y { get; set; }

    public int? Z { get; set; }

    public int? Type { get; set; }

    public int? Data { get; set; }

    public byte[]? Meta { get; set; }

    public byte[]? Blockdata { get; set; }

    public sbyte? Action { get; set; }

    public sbyte? RolledBack { get; set; }
}
