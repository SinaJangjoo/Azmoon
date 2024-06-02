using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Azmoon.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ExamPeriod> ExamPeriods { get; set; }

    public virtual DbSet<TblApplicant> TblApplicants { get; set; }

    public virtual DbSet<TblApplicant1> TblApplicants1 { get; set; }

    public virtual DbSet<TblApplicantDetail> TblApplicantDetails { get; set; }

    public virtual DbSet<TblCity> TblCities { get; set; }

    public virtual DbSet<TblJudgeField> TblJudgeFields { get; set; }

    public virtual DbSet<TblQuotum> TblQuota { get; set; }

    public virtual DbSet<TblScore> TblScores { get; set; }

    public virtual DbSet<TblState> TblStates { get; set; }

    public virtual DbSet<TblStudyField> TblStudyFields { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Azmoon;User ID=sa;Password=123@qaz;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_CI_AS");

        modelBuilder.Entity<TblApplicant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("__Tbl_Applicant");

            entity.Property(e => e.AliasName).HasMaxLength(50);
            entity.Property(e => e.BirthCertificate).HasMaxLength(50);
            entity.Property(e => e.BirthCertificateCityId).HasColumnName("BirthCertificateCity_Id");
            entity.Property(e => e.BirthCityId).HasColumnName("BirthCity_Id");
            entity.Property(e => e.BirthDate).HasMaxLength(50);
            entity.Property(e => e.CandidateNo).HasMaxLength(50);
            entity.Property(e => e.CityId).HasColumnName("City_Id");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.EssentialMobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherName).HasMaxLength(50);
            entity.Property(e => e.FileNo).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NationalNumber).HasMaxLength(50);
            entity.Property(e => e.PostalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreLastName).HasMaxLength(50);
            entity.Property(e => e.StateId).HasColumnName("State_Id");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrackingCode).HasMaxLength(150);
            entity.Property(e => e.WorkCityId).HasColumnName("WorkCity_Id");
            entity.Property(e => e.WorkPostalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkStateId).HasColumnName("WorkState_Id");
            entity.Property(e => e.WorkTel)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblApplicant1>(entity =>
        {
            entity.ToTable("Tbl_Applicant");

            entity.Property(e => e.Address).HasComment("آدرس پستی");
            entity.Property(e => e.AliasName)
                .HasMaxLength(50)
                .HasComment("نام مستعار");
            entity.Property(e => e.BirthCertificate)
                .HasMaxLength(50)
                .HasComment("شماره شناسنامه");
            entity.Property(e => e.BirthCertificateCityId)
                .HasComment("کد شهر محل صدور شناسنامه")
                .HasColumnName("BirthCertificateCity_Id");
            entity.Property(e => e.BirthCityId)
                .HasComment("کد شهر محل تولد")
                .HasColumnName("BirthCity_Id");
            entity.Property(e => e.BirthDate)
                .HasMaxLength(50)
                .HasComment("تاریخ تولی");
            entity.Property(e => e.CandidateNo)
                .HasMaxLength(50)
                .HasComment("شماره داوطلبی");
            entity.Property(e => e.CityId)
                .HasComment("کد شهر اقامت")
                .HasColumnName("City_Id");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasComment("ایمیل");
            entity.Property(e => e.EssentialMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("تلفن همراه ضروری");
            entity.Property(e => e.FatherName)
                .HasMaxLength(50)
                .HasComment("نام پدر");
            entity.Property(e => e.FileNo)
                .HasMaxLength(50)
                .HasComment("شماره پرونده");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasComment("نام");
            entity.Property(e => e.Gender).HasComment("جنسیت\r\n1:زن\r\n2:مرد\r\n");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasComment("نام خانوادگی");
            entity.Property(e => e.LeftHanded).HasComment("چپ دست\r\n0-خیر\r\n1-بله\r\n");
            entity.Property(e => e.MaritalStatus).HasComment("وضعیت تاهل\r\n1:مجرد\r\n2:متاهل\r\n");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("تلفن همراه");
            entity.Property(e => e.NationalNumber)
                .HasMaxLength(50)
                .HasComment("کد ملی");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("کد پستی");
            entity.Property(e => e.PreLastName)
                .HasMaxLength(50)
                .HasComment("نام خانوادگی قبلی");
            entity.Property(e => e.Religion).HasComment("دین\r\n1-اسلام\r\n2-كليمي\r\n3-مسيحي\r\n4-زرتشتي\r\n");
            entity.Property(e => e.StateId)
                .HasComment("کد استان اقامت")
                .HasColumnName("State_Id");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("تلفن ثابت");
            entity.Property(e => e.TrackingCode)
                .HasMaxLength(150)
                .HasComment("کد پیگیری ثبت نام");
            entity.Property(e => e.WorkAddress).HasComment("آدرس محل کار");
            entity.Property(e => e.WorkCityId)
                .HasComment("شهرستان محل کار")
                .HasColumnName("WorkCity_Id");
            entity.Property(e => e.WorkPostalCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("کد پستی محل کار");
            entity.Property(e => e.WorkStateId)
                .HasComment("استان محل کار")
                .HasColumnName("WorkState_Id");
            entity.Property(e => e.WorkTel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("تلفن محل کار");

            entity.HasOne(d => d.BirthCertificateCity).WithMany(p => p.TblApplicant1BirthCertificateCities)
                .HasForeignKey(d => d.BirthCertificateCityId)
                .HasConstraintName("FK_Tbl_Applicant_Tbl_City2");

            entity.HasOne(d => d.BirthCity).WithMany(p => p.TblApplicant1BirthCities)
                .HasForeignKey(d => d.BirthCityId)
                .HasConstraintName("FK_Tbl_Applicant_Tbl_City");

            entity.HasOne(d => d.City).WithMany(p => p.TblApplicant1Cities)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_Tbl_Applicant_Tbl_City1");

            entity.HasOne(d => d.State).WithMany(p => p.TblApplicant1States)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_Tbl_Applicant_Tbl_State2");

            entity.HasOne(d => d.WorkCity).WithMany(p => p.TblApplicant1WorkCities)
                .HasForeignKey(d => d.WorkCityId)
                .HasConstraintName("FK_Tbl_Applicant_Tbl_City3");

            entity.HasOne(d => d.WorkState).WithMany(p => p.TblApplicant1WorkStates)
                .HasForeignKey(d => d.WorkStateId)
                .HasConstraintName("FK_Tbl_Applicant_Tbl_State3");
        });

        modelBuilder.Entity<TblApplicantDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tbl_ApplicantDetail");

            entity.Property(e => e.ChangeCourse).HasComment("متقاضی تغییر رشته");
            entity.Property(e => e.CurrentJudgeFieldId)
                .HasComment("کد رشته کارشناسی فعلی")
                .HasColumnName("CurrentJudgeField_Id");
            entity.Property(e => e.CurrentJudgeRegionId)
                .HasComment("کد منطقه محل کارشناسی فعلی")
                .HasColumnName("CurrentJudgeRegion_Id");
            entity.Property(e => e.CurrentJudgeStateId)
                .HasComment("کد استان محل کارشناسی فعلی")
                .HasColumnName("CurrentJudgeState_Id");
            entity.Property(e => e.ExamAreaCityId)
                .HasComment("کد شهربراي تعيين حوزه امتحاني")
                .HasColumnName("ExamAreaCity_Id");
            entity.Property(e => e.ExamAreaStateId)
                .HasComment("کد استان براي تعيين حوزه امتحاني")
                .HasColumnName("ExamAreaState_Id");
            entity.Property(e => e.FileNo).HasMaxLength(50);
            entity.Property(e => e.GraduationDate)
                .HasMaxLength(50)
                .HasComment("تاریخ فارغ التحصیلی");
            entity.Property(e => e.JudgeLicenseNumber)
                .HasMaxLength(50)
                .HasComment("شماره پروانه کارشناسی");
            entity.Property(e => e.MilitaryDate)
                .HasMaxLength(50)
                .HasComment("تاریخ خدمت");
            entity.Property(e => e.MilitaryDuration).HasComment("مدت خدمت");
            entity.Property(e => e.MilitaryStatus).HasComment("وضعیت نظام وظیفه\r\n0- ندارد\r\n1- کارت پایان خدمت\r\n2-کارت معافیت\r\n");
            entity.Property(e => e.PicPath).HasComment("شاخه تصویر");
            entity.Property(e => e.QuotaCode)
                .HasMaxLength(150)
                .HasComment("کد سهمیه ایثارگری");
            entity.Property(e => e.QuotaId)
                .HasComment("سهمیه ایثارگری")
                .HasColumnName("Quota_Id");
            entity.Property(e => e.QuotaPreCode).HasComment("پیش کد ایثارگری\r\n0-ندارد\r\n1-ستاد کل نیروهای مسلح\r\n3-ارتش جمهوری اسلامی ایران\r\n4-سپاه پاسداران\r\n5-سازمان بسیج مستضعفین\r\n6-وزارت دفاع جمهوری اسلامی ایران\r\n7-نیروی انتظامی جمهوری اسلامی ایران\r\n8-جهاد کشاورزی\r\n");
            entity.Property(e => e.RegistryStatus).HasComment("وضعیت استعلام ثبت احوال\r\n0-  استعلام نشده است \r\n1-تایید شده\r\n4-  به داوطلب سرویس داده نمیشود\r\n");
            entity.Property(e => e.RequiredJudgeFieldId)
                .HasComment("کد رشته کارشناسی مورد تقاضا")
                .HasColumnName("RequiredJudgeField_Id");
            entity.Property(e => e.RequiredStateJudgeId)
                .HasComment("کد استان کارشناسی مورد تقاضا")
                .HasColumnName("RequiredStateJudge_Id");
            entity.Property(e => e.StudyFieldId)
                .HasComment("رشته تحصیلی")
                .HasColumnName("StudyField_Id");
            entity.Property(e => e.StudyGrade).HasComment("مقطع تحصیلی\r\n7: کارشناسی\r\n8: کارشناسی ارشد\r\n9: دكتري\r\n");
            entity.Property(e => e.Transfer).HasComment("متقاضی انتقال");
            entity.Property(e => e.UniversityId)
                .HasComment("دانشگاه محل تحصیل")
                .HasColumnName("University_Id");
            entity.Property(e => e.WarriorBirthCertificate)
                .HasMaxLength(50)
                .HasComment("شماره شناسنامه رزمنده");
            entity.Property(e => e.WarriorBirthDate)
                .HasMaxLength(50)
                .HasComment("تاریخ تولد رزمنده");
            entity.Property(e => e.WarriorFamily)
                .HasMaxLength(50)
                .HasComment("نام خانوادگی رزمنده");
            entity.Property(e => e.WarriorFatherName)
                .HasMaxLength(50)
                .HasComment("نام پدر رزمنده");
            entity.Property(e => e.WarriorName)
                .HasMaxLength(50)
                .HasComment("نام رزمنده");
            entity.Property(e => e.WarriorNationalNumber)
                .HasMaxLength(50)
                .HasComment("کد ملی رزمنده");
            entity.Property(e => e.WorkExperienceLength).HasComment("مدت سابقه کار (ماه)");
        });

        modelBuilder.Entity<TblCity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_City");

            entity.ToTable("Tbl_City");

            entity.Property(e => e.SanjeshId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Sanjesh_Id");
            entity.Property(e => e.StateId).HasColumnName("State_Id");
            entity.Property(e => e.Title).HasMaxLength(150);

            entity.HasOne(d => d.State).WithMany(p => p.TblCities)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_Tbl_City_Tbl_State");
        });

        modelBuilder.Entity<TblJudgeField>(entity =>
        {
            entity.ToTable("Tbl_JudgeField");

            entity.Property(e => e.SanjeshId).HasColumnName("Sanjesh_Id");
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<TblQuotum>(entity =>
        {
            entity.ToTable("Tbl_Quota");

            entity.Property(e => e.SanjeshId).HasColumnName("Sanjesh_Id");
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<TblScore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tbl_Score");

            entity.Property(e => e.AcceptanceFreeScore).HasComment("حدنصاب قبولی در سهمیه آزاد (در فایل اصلی سنجش به عنوان اخرین نمره قبولی در آزاد)");
            entity.Property(e => e.AcceptanceQuotaScore).HasComment("حدنصاب قبولی در سهمیه ایثارگری (در فایل سنجش با عنوان اخرین نمره قبولی در ایثارگری )");
            entity.Property(e => e.BalanceScore).HasComment("نمره تراز (درفایل اصلی سنجش این آیتم به اسم نمره کل درج شده ) ");
            entity.Property(e => e.FileNo)
                .HasMaxLength(50)
                .HasComment("شماره پرونده");
            entity.Property(e => e.RawScore).HasComment("نمره خام");
            entity.Property(e => e.ResultStatus).HasComment("کد وضعیت \r\n2:مردود");
        });

        modelBuilder.Entity<TblState>(entity =>
        {
            entity.ToTable("Tbl_State");

            entity.Property(e => e.SanjeshId).HasColumnName("Sanjesh_Id");
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<TblStudyField>(entity =>
        {
            entity.ToTable("Tbl_StudyField");

            entity.Property(e => e.SanjeshId).HasColumnName("Sanjesh_Id");
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
