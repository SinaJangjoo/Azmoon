using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Azmoon.Migrations
{
    /// <inheritdoc />
    public partial class addTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "__Tbl_Applicant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CandidateNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PreLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AliasName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<byte>(type: "tinyint", nullable: true),
                    MaritalStatus = table.Column<bool>(type: "bit", nullable: true),
                    BirthDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NationalNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BirthCertificate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BirthCertificateCity_Id = table.Column<int>(type: "int", nullable: true),
                    BirthCity_Id = table.Column<int>(type: "int", nullable: true),
                    Religion = table.Column<byte>(type: "tinyint", nullable: true),
                    LeftHanded = table.Column<bool>(type: "bit", nullable: true),
                    State_Id = table.Column<int>(type: "int", nullable: true),
                    City_Id = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WorkState_Id = table.Column<int>(type: "int", nullable: true),
                    WorkCity_Id = table.Column<int>(type: "int", nullable: true),
                    WorkAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkPostalCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WorkTel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EssentialMobile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TrackingCode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    MaritalCode = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ExamPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamPeriods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ApplicantDetail",
                columns: table => new
                {
                    MilitaryStatus = table.Column<short>(type: "smallint", nullable: true, comment: "وضعیت نظام وظیفه\r\n0- ندارد\r\n1- کارت پایان خدمت\r\n2-کارت معافیت\r\n"),
                    MilitaryDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "تاریخ خدمت"),
                    MilitaryDuration = table.Column<short>(type: "smallint", nullable: true, comment: "مدت خدمت"),
                    Quota_Id = table.Column<int>(type: "int", nullable: true, comment: "سهمیه ایثارگری"),
                    QuotaCode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true, comment: "کد سهمیه ایثارگری"),
                    StudyGrade = table.Column<int>(type: "int", nullable: true, comment: "مقطع تحصیلی\r\n7: کارشناسی\r\n8: کارشناسی ارشد\r\n9: دكتري\r\n"),
                    StudyField_Id = table.Column<int>(type: "int", nullable: true, comment: "رشته تحصیلی"),
                    GraduationDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "تاریخ فارغ التحصیلی"),
                    University_Id = table.Column<int>(type: "int", nullable: true, comment: "دانشگاه محل تحصیل"),
                    Transfer = table.Column<bool>(type: "bit", nullable: true, comment: "متقاضی انتقال"),
                    ChangeCourse = table.Column<bool>(type: "bit", nullable: true, comment: "متقاضی تغییر رشته"),
                    CurrentJudgeState_Id = table.Column<int>(type: "int", nullable: true, comment: "کد استان محل کارشناسی فعلی"),
                    CurrentJudgeRegion_Id = table.Column<int>(type: "int", nullable: true, comment: "کد منطقه محل کارشناسی فعلی"),
                    CurrentJudgeField_Id = table.Column<int>(type: "int", nullable: true, comment: "کد رشته کارشناسی فعلی"),
                    JudgeLicenseNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "شماره پروانه کارشناسی"),
                    WorkExperienceLength = table.Column<short>(type: "smallint", nullable: true, comment: "مدت سابقه کار (ماه)"),
                    RequiredJudgeField_Id = table.Column<int>(type: "int", nullable: true, comment: "کد رشته کارشناسی مورد تقاضا"),
                    RequiredStateJudge_Id = table.Column<int>(type: "int", nullable: true, comment: "کد استان کارشناسی مورد تقاضا"),
                    ExamAreaState_Id = table.Column<int>(type: "int", nullable: true, comment: "کد استان براي تعيين حوزه امتحاني"),
                    ExamAreaCity_Id = table.Column<int>(type: "int", nullable: true, comment: "کد شهربراي تعيين حوزه امتحاني"),
                    PicPath = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "شاخه تصویر"),
                    WarriorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "نام رزمنده"),
                    WarriorFamily = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "نام خانوادگی رزمنده"),
                    WarriorFatherName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "نام پدر رزمنده"),
                    WarriorBirthDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "تاریخ تولد رزمنده"),
                    WarriorBirthCertificate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "شماره شناسنامه رزمنده"),
                    WarriorNationalNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "کد ملی رزمنده"),
                    QuotaPreCode = table.Column<byte>(type: "tinyint", nullable: true, comment: "پیش کد ایثارگری\r\n0-ندارد\r\n1-ستاد کل نیروهای مسلح\r\n3-ارتش جمهوری اسلامی ایران\r\n4-سپاه پاسداران\r\n5-سازمان بسیج مستضعفین\r\n6-وزارت دفاع جمهوری اسلامی ایران\r\n7-نیروی انتظامی جمهوری اسلامی ایران\r\n8-جهاد کشاورزی\r\n"),
                    RegistryStatus = table.Column<byte>(type: "tinyint", nullable: true, comment: "وضعیت استعلام ثبت احوال\r\n0-  استعلام نشده است \r\n1-تایید شده\r\n4-  به داوطلب سرویس داده نمیشود\r\n"),
                    FileNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tbl_JudgeField",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Sanjesh_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_JudgeField", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Quota",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Sanjesh_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Quota", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Score",
                columns: table => new
                {
                    RawScore = table.Column<short>(type: "smallint", nullable: true, comment: "نمره خام"),
                    BalanceScore = table.Column<short>(type: "smallint", nullable: true, comment: "نمره تراز (درفایل اصلی سنجش این آیتم به اسم نمره کل درج شده ) "),
                    AcceptanceFreeScore = table.Column<short>(type: "smallint", nullable: true, comment: "حدنصاب قبولی در سهمیه آزاد (در فایل اصلی سنجش به عنوان اخرین نمره قبولی در آزاد)"),
                    AcceptanceQuotaScore = table.Column<short>(type: "smallint", nullable: true, comment: "حدنصاب قبولی در سهمیه ایثارگری (در فایل سنجش با عنوان اخرین نمره قبولی در ایثارگری )"),
                    ResultStatus = table.Column<byte>(type: "tinyint", nullable: true, comment: "کد وضعیت \r\n2:مردود"),
                    FileNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "شماره پرونده")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tbl_State",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Sanjesh_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_StudyField",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Sanjesh_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_StudyField", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    State_Id = table.Column<int>(type: "int", nullable: true),
                    Sanjesh_Id = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    RegionCode = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_City_Tbl_State",
                        column: x => x.State_Id,
                        principalTable: "Tbl_State",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Applicant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "شماره پرونده"),
                    CandidateNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "شماره داوطلبی"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "نام"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "نام خانوادگی"),
                    PreLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "نام خانوادگی قبلی"),
                    AliasName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "نام مستعار"),
                    FatherName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "نام پدر"),
                    Gender = table.Column<byte>(type: "tinyint", nullable: true, comment: "جنسیت\r\n1:زن\r\n2:مرد\r\n"),
                    MaritalStatus = table.Column<bool>(type: "bit", nullable: true, comment: "وضعیت تاهل\r\n1:مجرد\r\n2:متاهل\r\n"),
                    BirthDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "تاریخ تولی"),
                    NationalNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "کد ملی"),
                    BirthCertificate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "شماره شناسنامه"),
                    BirthCertificateCity_Id = table.Column<int>(type: "int", nullable: true, comment: "کد شهر محل صدور شناسنامه"),
                    BirthCity_Id = table.Column<int>(type: "int", nullable: true, comment: "کد شهر محل تولد"),
                    Religion = table.Column<byte>(type: "tinyint", nullable: true, comment: "دین\r\n1-اسلام\r\n2-كليمي\r\n3-مسيحي\r\n4-زرتشتي\r\n"),
                    LeftHanded = table.Column<bool>(type: "bit", nullable: true, comment: "چپ دست\r\n0-خیر\r\n1-بله\r\n"),
                    State_Id = table.Column<int>(type: "int", nullable: true, comment: "کد استان اقامت"),
                    City_Id = table.Column<int>(type: "int", nullable: true, comment: "کد شهر اقامت"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "آدرس پستی"),
                    PostalCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "کد پستی"),
                    Tel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "تلفن ثابت"),
                    Mobile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "تلفن همراه"),
                    WorkState_Id = table.Column<int>(type: "int", nullable: true, comment: "استان محل کار"),
                    WorkCity_Id = table.Column<int>(type: "int", nullable: true, comment: "شهرستان محل کار"),
                    WorkAddress = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "آدرس محل کار"),
                    WorkPostalCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "کد پستی محل کار"),
                    WorkTel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "تلفن محل کار"),
                    EssentialMobile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "تلفن همراه ضروری"),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true, comment: "ایمیل"),
                    TrackingCode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true, comment: "کد پیگیری ثبت نام"),
                    MaritalCode = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Applicant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Applicant_Tbl_City",
                        column: x => x.BirthCity_Id,
                        principalTable: "Tbl_City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tbl_Applicant_Tbl_City1",
                        column: x => x.City_Id,
                        principalTable: "Tbl_City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tbl_Applicant_Tbl_City2",
                        column: x => x.BirthCertificateCity_Id,
                        principalTable: "Tbl_City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tbl_Applicant_Tbl_City3",
                        column: x => x.WorkCity_Id,
                        principalTable: "Tbl_City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tbl_Applicant_Tbl_State2",
                        column: x => x.State_Id,
                        principalTable: "Tbl_State",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tbl_Applicant_Tbl_State3",
                        column: x => x.WorkState_Id,
                        principalTable: "Tbl_State",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Applicant_BirthCertificateCity_Id",
                table: "Tbl_Applicant",
                column: "BirthCertificateCity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Applicant_BirthCity_Id",
                table: "Tbl_Applicant",
                column: "BirthCity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Applicant_City_Id",
                table: "Tbl_Applicant",
                column: "City_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Applicant_State_Id",
                table: "Tbl_Applicant",
                column: "State_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Applicant_WorkCity_Id",
                table: "Tbl_Applicant",
                column: "WorkCity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Applicant_WorkState_Id",
                table: "Tbl_Applicant",
                column: "WorkState_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_City_State_Id",
                table: "Tbl_City",
                column: "State_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__Tbl_Applicant");

            migrationBuilder.DropTable(
                name: "ExamPeriods");

            migrationBuilder.DropTable(
                name: "Tbl_Applicant");

            migrationBuilder.DropTable(
                name: "Tbl_ApplicantDetail");

            migrationBuilder.DropTable(
                name: "Tbl_JudgeField");

            migrationBuilder.DropTable(
                name: "Tbl_Quota");

            migrationBuilder.DropTable(
                name: "Tbl_Score");

            migrationBuilder.DropTable(
                name: "Tbl_StudyField");

            migrationBuilder.DropTable(
                name: "Tbl_City");

            migrationBuilder.DropTable(
                name: "Tbl_State");
        }
    }
}
