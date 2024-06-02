using System;
using System.Collections.Generic;

namespace Azmoon.Models;

public partial class TblCity
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? StateId { get; set; }

    public string? SanjeshId { get; set; }

    public short? RegionCode { get; set; }

    public virtual TblState? State { get; set; }

    public virtual ICollection<TblApplicant1> TblApplicant1BirthCertificateCities { get; set; } = new List<TblApplicant1>();

    public virtual ICollection<TblApplicant1> TblApplicant1BirthCities { get; set; } = new List<TblApplicant1>();

    public virtual ICollection<TblApplicant1> TblApplicant1Cities { get; set; } = new List<TblApplicant1>();

    public virtual ICollection<TblApplicant1> TblApplicant1WorkCities { get; set; } = new List<TblApplicant1>();
}
