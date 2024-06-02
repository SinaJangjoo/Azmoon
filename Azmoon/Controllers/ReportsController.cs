using Azmoon.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace Azmoon.Controllers
{
    public class ReportsController : Controller
    {
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _hostingEnvironment;
        public ReportsController(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReportsLog(List<int> selectedId, List<string> selectedFName,
           List<string> selectedLName, List<string> selectedPostalCode, List<string> selectedTel,
           List<string> selectedEmail, string title)
        {
            ReportsViewModel VM = new();
            VM.Id = selectedId;
            VM.FirstName = selectedFName;
            VM.LastName = selectedLName;
            VM.PostalCode = selectedPostalCode; ;
            VM.Tel = selectedTel;
            VM.Email = selectedEmail;
            VM.Title = title;

            ViewBag.tempdataId = TempData["Id"] = selectedId;
            ViewBag.tempdataFName = TempData["FirstName"] = selectedFName;
            ViewBag.tempdataLName = TempData["LastName"] = selectedLName;
            ViewBag.tempdataPostalCode = TempData["PostalCode"] = selectedPostalCode;
            ViewBag.tempdataTel = TempData["Tel"] = selectedTel;
            ViewBag.tempdataEmail = TempData["Email"] = selectedEmail;
            TempData["Title"] = title;

            return View(VM);
        }

        public async Task<IActionResult> PrintPdf(List<object> data)
        {
           
                var LReportTitle = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["ReportTitle"];

                Stimulsoft.Report.StiReport report = new Stimulsoft.Report.StiReport();
                report.Load(_hostingEnvironment.ContentRootPath + "\\Reports\\AzmoonReports.mrt");

               
                //this LawyerCertificateStatistic table name should be in stimulsoft for reporting
                report.RegData("Tbl_Applicant", data: data);


                report.Dictionary.Variables["TitleL1"].Value = LReportTitle; //from appsettings.json
                report.Dictionary.Variables["TitleL2"].Value = "گزارش آماری وکلا";


                //report.Dictionary.Variables["imgArm"].ValueObject = Stimulsoft.Base.Drawing.StiImageFromURL.LoadBitmap(Directory.GetCurrentDirectory() + "/wwwroot/images/Arm.png");

                report.Dictionary.Variables["ReportDate"].Value = DateTime.Now + " - " +
                                                             DateTime.Now.TimeOfDay.ToString().Substring(0, 8);

                //var stiDatamonitor=new stidatamo
                //var res = report.ResponseAsPdf(report);
                await report.RenderAsync();
                string fullPath = await SaveReportAsync(report);
                var res = report.ExportDocument(StiExportFormat.Pdf, fullPath);
                //string fullPath = await SaveReportAsync(report);

                var stream = new FileStream(fullPath, FileMode.Open);
                return new FileStreamResult(stream, "application/pdf");
            
        }

        //public IActionResult ExportPdf()
        //{
        //    var report = this.GetReport();
        //    return StiNetCoreReportResponse.ResponseAsPdf(report);
        //}

        //public IActionResult ExportXls()
        //{
        //    var report = this.GetReport();
        //    return StiNetCoreReportResponse.ResponseAsXls(report);
        //}

        public static async Task<string> SaveReportAsync(StiReport res)
        {

            var directoryName = Path.Combine("Tmp");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), directoryName, "Reports");
            if (!Directory.Exists(pathToSave))
            {
                Directory.CreateDirectory(pathToSave);
            }
            var fileName = Guid.NewGuid().ToString("N");
            var extensionFile = Path.GetExtension(".pdf");
            var fullPath = Path.Combine(pathToSave, fileName + extensionFile);
            //await System.IO.File.WriteAllBytesAsync(fullPath, res.SaveDocumentToByteArray());
            return fullPath;


        }

    }
}
