using System;
using System.Collections.Generic;

namespace Azmoon.Models;

public partial class TblApplicant
{
    public int Id { get; set; }

    public string? FileNo { get; set; }

    public string? CandidateNo { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? PreLastName { get; set; }

    public string? AliasName { get; set; }

    public string? FatherName { get; set; }

    public byte? Gender { get; set; }

    public bool? MaritalStatus { get; set; }

    public string? BirthDate { get; set; }

    public string? NationalNumber { get; set; }

    public string? BirthCertificate { get; set; }

    public int? BirthCertificateCityId { get; set; }

    public int? BirthCityId { get; set; }

    public byte? Religion { get; set; }

    public bool? LeftHanded { get; set; }

    public int? StateId { get; set; }

    public int? CityId { get; set; }

    public string? Address { get; set; }

    public string? PostalCode { get; set; }

    public string? Tel { get; set; }

    public string? Mobile { get; set; }

    public int? WorkStateId { get; set; }

    public int? WorkCityId { get; set; }

    public string? WorkAddress { get; set; }

    public string? WorkPostalCode { get; set; }

    public string? WorkTel { get; set; }

    public string? EssentialMobile { get; set; }

    public string? Email { get; set; }

    public string? TrackingCode { get; set; }

    public byte? MaritalCode { get; set; }
}
