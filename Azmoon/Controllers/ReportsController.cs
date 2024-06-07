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

			var combinedList = new List<string>();

			if (VM.Id != null)
			{
				combinedList.AddRange(VM.Id.Select(i => i.ToString()));
			}
			if (VM.FirstName != null)
			{
				combinedList.AddRange(VM.FirstName.Select(i => i.ToString()));
			}
			if (VM.LastName != null)
			{
				combinedList.AddRange(VM.LastName.Select(i => i.ToString()));
			}
			if (VM.PostalCode != null)
			{
				combinedList.AddRange(VM.PostalCode.Select(i => i.ToString()));
			}
			if (VM.Tel != null)
			{
				combinedList.AddRange(VM.Tel.Select(i => i.ToString()));
			}
			if (VM.Email != null)
			{
				combinedList.AddRange(VM.Email.Select(i => i.ToString()));
			}
			VM.combinedList = combinedList;
			
			TempData["tle"] = title;

			return View(VM);
		}

		public async Task<IActionResult> PrintPdf(List<string> data)
		{

			//var LReportTitle = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["ReportTitle"];

			Stimulsoft.Report.StiReport report = new Stimulsoft.Report.StiReport();
			report.Load(_hostingEnvironment.ContentRootPath + "\\Reports\\AzmoonReports.mrt");


			//this LawyerCertificateStatistic table name should be in stimulsoft for reporting
			report.RegData("AzmoonReports", data: data);

			//ReportsViewModel model = new ReportsViewModel();
			report.Dictionary.Variables["Title"].Value =Convert.ToString( TempData["tle"]);


			//report.Dictionary.Variables["imgArm"].ValueObject = Stimulsoft.Base.Drawing.StiImageFromURL.LoadBitmap(Directory.GetCurrentDirectory() + "/wwwroot/images/Arm.png");

			report.Dictionary.Variables["ReportDate"].Value = DateTime.Now + " - " +
															 DateTime.Now.TimeOfDay.ToString().Substring(0, 8);

			await report.RenderAsync();
			string fullPath = await SaveReportAsync(report);
			var res = report.ExportDocument(StiExportFormat.Pdf, fullPath);

			var stream = new FileStream(fullPath, FileMode.Open);
			return new FileStreamResult(stream, "application/pdf");

		}

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