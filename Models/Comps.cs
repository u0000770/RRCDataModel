using System;
using System.Collections.Generic;

namespace RRCDataModel.Models;

public partial class Comps
{
    public int EFKey { get; set; }

    public string? Title { get; set; }

    public string? Code { get; set; }

    public bool? Active { get; set; }
}
