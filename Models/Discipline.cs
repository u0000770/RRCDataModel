using System;
using System.Collections.Generic;

namespace RRCDataModel.Models;

public partial class Discipline
{
    public int id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool Active { get; set; }
}
