using System;
using System.Collections.Generic;

namespace Azmoon.Models;

public partial class TblApplicant1
{
    public int Id { get; set; }

    /// <summary>
    /// شماره پرونده
    /// </summary>
    public string? FileNo { get; set; }

    /// <summary>
    /// شماره داوطلبی
    /// </summary>
    public string? CandidateNo { get; set; }

    /// <summary>
    /// نام
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// نام خانوادگی
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// نام خانوادگی قبلی
    /// </summary>
    public string? PreLastName { get; set; }

    /// <summary>
    /// نام مستعار
    /// </summary>
    public string? AliasName { get; set; }

    /// <summary>
    /// نام پدر
    /// </summary>
    public string? FatherName { get; set; }

    /// <summary>
    /// جنسیت
    /// 1:زن
    /// 2:مرد
    /// 
    /// </summary>
    public byte? Gender { get; set; }

    /// <summary>
    /// وضعیت تاهل
    /// 1:مجرد
    /// 2:متاهل
    /// 
    /// </summary>
    public bool? MaritalStatus { get; set; }

    /// <summary>
    /// تاریخ تولی
    /// </summary>
    public string? BirthDate { get; set; }

    /// <summary>
    /// کد ملی
    /// </summary>
    public string? NationalNumber { get; set; }

    /// <summary>
    /// شماره شناسنامه
    /// </summary>
    public string? BirthCertificate { get; set; }

    /// <summary>
    /// کد شهر محل صدور شناسنامه
    /// </summary>
    public int? BirthCertificateCityId { get; set; }

    /// <summary>
    /// کد شهر محل تولد
    /// </summary>
    public int? BirthCityId { get; set; }

    /// <summary>
    /// دین
    /// 1-اسلام
    /// 2-كليمي
    /// 3-مسيحي
    /// 4-زرتشتي
    /// 
    /// </summary>
    public byte? Religion { get; set; }

    /// <summary>
    /// چپ دست
    /// 0-خیر
    /// 1-بله
    /// 
    /// </summary>
    public bool? LeftHanded { get; set; }

    /// <summary>
    /// کد استان اقامت
    /// </summary>
    public int? StateId { get; set; }

    /// <summary>
    /// کد شهر اقامت
    /// </summary>
    public int? CityId { get; set; }

    /// <summary>
    /// آدرس پستی
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// کد پستی
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// تلفن ثابت
    /// </summary>
    public string? Tel { get; set; }

    /// <summary>
    /// تلفن همراه
    /// </summary>
    public string? Mobile { get; set; }

    /// <summary>
    /// استان محل کار
    /// </summary>
    public int? WorkStateId { get; set; }

    /// <summary>
    /// شهرستان محل کار
    /// </summary>
    public int? WorkCityId { get; set; }

    /// <summary>
    /// آدرس محل کار
    /// </summary>
    public string? WorkAddress { get; set; }

    /// <summary>
    /// کد پستی محل کار
    /// </summary>
    public string? WorkPostalCode { get; set; }

    /// <summary>
    /// تلفن محل کار
    /// </summary>
    public string? WorkTel { get; set; }

    /// <summary>
    /// تلفن همراه ضروری
    /// </summary>
    public string? EssentialMobile { get; set; }

    /// <summary>
    /// ایمیل
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// کد پیگیری ثبت نام
    /// </summary>
    public string? TrackingCode { get; set; }

    public byte? MaritalCode { get; set; }

    public virtual TblCity? BirthCertificateCity { get; set; }

    public virtual TblCity? BirthCity { get; set; }

    public virtual TblCity? City { get; set; }

    public virtual TblState? State { get; set; }

    public virtual TblCity? WorkCity { get; set; }

    public virtual TblState? WorkState { get; set; }
}
