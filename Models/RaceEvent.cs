using System;
using System.Collections.Generic;

namespace RRCDataModel.Models;

public partial class RaceEvent
{
    public int EFKey { get; set; }

    public int EventId { get; set; }

    public DateTime Date { get; set; }

    public bool Active { get; set; }

    public virtual Events Event { get; set; } = null!;
}
