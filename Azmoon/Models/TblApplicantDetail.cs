using System;
using System.Collections.Generic;

namespace Azmoon.Models;

public partial class TblApplicantDetail
{
    /// <summary>
    /// وضعیت نظام وظیفه
    /// 0- ندارد
    /// 1- کارت پایان خدمت
    /// 2-کارت معافیت
    /// 
    /// </summary>
    public short? MilitaryStatus { get; set; }

    /// <summary>
    /// تاریخ خدمت
    /// </summary>
    public string? MilitaryDate { get; set; }

    /// <summary>
    /// مدت خدمت
    /// </summary>
    public short? MilitaryDuration { get; set; }

    /// <summary>
    /// سهمیه ایثارگری
    /// </summary>
    public int? QuotaId { get; set; }

    /// <summary>
    /// کد سهمیه ایثارگری
    /// </summary>
    public string? QuotaCode { get; set; }

    /// <summary>
    /// مقطع تحصیلی
    /// 7: کارشناسی
    /// 8: کارشناسی ارشد
    /// 9: دكتري
    /// 
    /// </summary>
    public int? StudyGrade { get; set; }

    /// <summary>
    /// رشته تحصیلی
    /// </summary>
    public int? StudyFieldId { get; set; }

    /// <summary>
    /// تاریخ فارغ التحصیلی
    /// </summary>
    public string? GraduationDate { get; set; }

    /// <summary>
    /// دانشگاه محل تحصیل
    /// </summary>
    public int? UniversityId { get; set; }

    /// <summary>
    /// متقاضی انتقال
    /// </summary>
    public bool? Transfer { get; set; }

    /// <summary>
    /// متقاضی تغییر رشته
    /// </summary>
    public bool? ChangeCourse { get; set; }

    /// <summary>
    /// کد استان محل کارشناسی فعلی
    /// </summary>
    public int? CurrentJudgeStateId { get; set; }

    /// <summary>
    /// کد منطقه محل کارشناسی فعلی
    /// </summary>
    public int? CurrentJudgeRegionId { get; set; }

    /// <summary>
    /// کد رشته کارشناسی فعلی
    /// </summary>
    public int? CurrentJudgeFieldId { get; set; }

    /// <summary>
    /// شماره پروانه کارشناسی
    /// </summary>
    public string? JudgeLicenseNumber { get; set; }

    /// <summary>
    /// مدت سابقه کار (ماه)
    /// </summary>
    public short? WorkExperienceLength { get; set; }

    /// <summary>
    /// کد رشته کارشناسی مورد تقاضا
    /// </summary>
    public int? RequiredJudgeFieldId { get; set; }

    /// <summary>
    /// کد استان کارشناسی مورد تقاضا
    /// </summary>
    public int? RequiredStateJudgeId { get; set; }

    /// <summary>
    /// کد استان براي تعيين حوزه امتحاني
    /// </summary>
    public int? ExamAreaStateId { get; set; }

    /// <summary>
    /// کد شهربراي تعيين حوزه امتحاني
    /// </summary>
    public int? ExamAreaCityId { get; set; }

    /// <summary>
    /// شاخه تصویر
    /// </summary>
    public string? PicPath { get; set; }

    /// <summary>
    /// نام رزمنده
    /// </summary>
    public string? WarriorName { get; set; }

    /// <summary>
    /// نام خانوادگی رزمنده
    /// </summary>
    public string? WarriorFamily { get; set; }

    /// <summary>
    /// نام پدر رزمنده
    /// </summary>
    public string? WarriorFatherName { get; set; }

    /// <summary>
    /// تاریخ تولد رزمنده
    /// </summary>
    public string? WarriorBirthDate { get; set; }

    /// <summary>
    /// شماره شناسنامه رزمنده
    /// </summary>
    public string? WarriorBirthCertificate { get; set; }

    /// <summary>
    /// کد ملی رزمنده
    /// </summary>
    public string? WarriorNationalNumber { get; set; }

    /// <summary>
    /// پیش کد ایثارگری
    /// 0-ندارد
    /// 1-ستاد کل نیروهای مسلح
    /// 3-ارتش جمهوری اسلامی ایران
    /// 4-سپاه پاسداران
    /// 5-سازمان بسیج مستضعفین
    /// 6-وزارت دفاع جمهوری اسلامی ایران
    /// 7-نیروی انتظامی جمهوری اسلامی ایران
    /// 8-جهاد کشاورزی
    /// 
    /// </summary>
    public byte? QuotaPreCode { get; set; }

    /// <summary>
    /// وضعیت استعلام ثبت احوال
    /// 0-  استعلام نشده است 
    /// 1-تایید شده
    /// 4-  به داوطلب سرویس داده نمیشود
    /// 
    /// </summary>
    public byte? RegistryStatus { get; set; }

    public string? FileNo { get; set; }
}
