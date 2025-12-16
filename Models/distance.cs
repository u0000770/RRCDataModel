using System;
using System.Collections.Generic;

namespace RRCDataModel.Models;

public partial class distance
{
    public int EFKey { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public double Distance1 { get; set; }
}
