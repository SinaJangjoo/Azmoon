using System;
using System.Collections.Generic;

namespace Azmoon.Models;

public partial class ExamPeriod
{
    public int Id { get; set; }

    public string ExamTitle { get; set; } = null!;

    public DateTime InsertTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public bool IsRemoved { get; set; }

    public DateTime? RemoveTime { get; set; }
}
