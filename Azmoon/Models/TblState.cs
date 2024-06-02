using System;
using System.Collections.Generic;

namespace Azmoon.Models;

public partial class TblState
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? SanjeshId { get; set; }

    public virtual ICollection<TblApplicant1> TblApplicant1States { get; set; } = new List<TblApplicant1>();

    public virtual ICollection<TblApplicant1> TblApplicant1WorkStates { get; set; } = new List<TblApplicant1>();

    public virtual ICollection<TblCity> TblCities { get; set; } = new List<TblCity>();
}
