using System;
using System.Collections.Generic;

namespace RRCDataModel.Models;

public partial class EventRunnerTimes
{
    public int EFKey { get; set; }

    public int RunnerId { get; set; }

    public int EventId { get; set; }

    public int? Target { get; set; }

    public int? Actual { get; set; }

    public DateTime? Date { get; set; }

    public bool? Active { get; set; }

    public int? RaceEventId { get; set; }

    public virtual Events Event { get; set; } = null!;

    public virtual runners Runner { get; set; } = null!;
}
