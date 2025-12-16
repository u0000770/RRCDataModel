using System;
using System.Collections.Generic;

namespace RRCDataModel.Models;

public partial class LastRace
{
    public int EFKey { get; set; }

    public int RunnerId { get; set; }

    public double Distance { get; set; }

    public int Time { get; set; }

    public DateTime Date { get; set; }

    public virtual runners Runner { get; set; } = null!;
}
