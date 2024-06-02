using System;
using System.Collections.Generic;

namespace Azmoon.Models;

public partial class TblScore
{
    /// <summary>
    /// نمره خام
    /// </summary>
    public short? RawScore { get; set; }

    /// <summary>
    /// نمره تراز (درفایل اصلی سنجش این آیتم به اسم نمره کل درج شده ) 
    /// </summary>
    public short? BalanceScore { get; set; }

    /// <summary>
    /// حدنصاب قبولی در سهمیه آزاد (در فایل اصلی سنجش به عنوان اخرین نمره قبولی در آزاد)
    /// </summary>
    public short? AcceptanceFreeScore { get; set; }

    /// <summary>
    /// حدنصاب قبولی در سهمیه ایثارگری (در فایل سنجش با عنوان اخرین نمره قبولی در ایثارگری )
    /// </summary>
    public short? AcceptanceQuotaScore { get; set; }

    /// <summary>
    /// کد وضعیت 
    /// 2:مردود
    /// </summary>
    public byte? ResultStatus { get; set; }

    /// <summary>
    /// شماره پرونده
    /// </summary>
    public string? FileNo { get; set; }
}
