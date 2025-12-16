using System;
using System.Collections.Generic;

namespace RRCDataModel.Models;

public partial class runners
{
    public int EFKey { get; set; }

    public string firstname { get; set; } = null!;

    public string secondname { get; set; } = null!;

    public string? ukan { get; set; }

    public DateOnly? dob { get; set; }

    public string? email { get; set; }

    public bool? Active { get; set; }

    public string? ageGradeCode { get; set; }

    public bool? gender { get; set; }

    public virtual ICollection<EventRunnerTimes> EventRunnerTimes { get; set; } = new List<EventRunnerTimes>();

    public virtual ICollection<LastRace> LastRace { get; set; } = new List<LastRace>();

    public virtual ICollection<NextRace> NextRace { get; set; } = new List<NextRace>();
}
