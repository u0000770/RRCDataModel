using System;
using System.Collections.Generic;

namespace RRCDataModel.Models;

public partial class Events
{
    public int EFKey { get; set; }

    public string? Title { get; set; }

    public string? Venue { get; set; }

    public string? Discipline { get; set; }

    public string? DistanceCode { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<EventRunnerTimes> EventRunnerTimes { get; set; } = new List<EventRunnerTimes>();

    public virtual ICollection<RaceEvent> RaceEvent { get; set; } = new List<RaceEvent>();
}
