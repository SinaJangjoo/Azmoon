using Aspose.Cells;
using Azmoon.Models;
using Azmoon.Utilities;
using Azmoon.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Azmoon.Controllers
{
    public class SecondReportsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SecondReportsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReportConfirm(List<string> selectedColumns, string title)
        {
            SecondReportsViewModel viewModel = new();
            viewModel.Title = title;
            viewModel.selectedColumns.AddRange(selectedColumns);
            return View(viewModel);
        }
        public IActionResult PreReport(SecondReportsViewModel viewModel)
        {

            var workbook = new Workbook();
            var worksheet = workbook.Worksheets[0];

            worksheet.Cells["A2"].PutValue("ID");
            worksheet.Cells["B2"].PutValue("FirstName");
            worksheet.Cells["C2"].PutValue("LastName");
            worksheet.Cells["D2"].PutValue("PostalCode");
            worksheet.Cells["E2"].PutValue("Tel");
            worksheet.Cells["F2"].PutValue("Email");

            worksheet.Cells.Merge(0, 0, 1, 6);
            worksheet.Cells[0, 0].PutValue(viewModel.Title);

            Style style = workbook.CreateStyle();
            style.HorizontalAlignment = TextAlignmentType.Center;
            style.VerticalAlignment = TextAlignmentType.Center;
            style.Font.IsBold = true;
            worksheet.Cells[0, 0].SetStyle(style);

            foreach (var column in viewModel.selectedColumns)
            {
                if (SD.allColumns.Contains(column))
                {
                    switch (column.ToLower())
                    {
                        case "id":
                            var ids = _db.TblApplicants.Select(a => a.Id).ToList();
                            for (int i = 0; i < ids.Count; i++)
                            {
                                worksheet.Cells[$"A{i + 4}"].PutValue(ids[i]);
                            }
                            break;
                        case "firstname":
                            var firstNames = _db.TblApplicants.Select(a => a.FirstName).ToList();
                            for (int i = 0; i < firstNames.Count; i++)
                            {
                                worksheet.Cells[$"B{i + 4}"].PutValue(firstNames[i]);
                            }
                            break;
                        case "lastname":
                            var lastNames = _db.TblApplicants.Select(a => a.LastName).ToList();
                            for (int i = 0; i < lastNames.Count; i++)
                            {
                                worksheet.Cells[$"C{i + 4}"].PutValue(lastNames[i]);
                            }
                            break;
                        case "postalcode":
                            var postalCodes = _db.TblApplicants.Select(a => a.PostalCode).ToList();
                            for (int i = 0; i < postalCodes.Count; i++)
                            {
                                worksheet.Cells[$"D{i + 4}"].PutValue(postalCodes[i]);
                            }
                            break;
                        case "tel":
                            var tels = _db.TblApplicants.Select(a => a.Tel).ToList();
                            for (int i = 0; i < tels.Count; i++)
                            {
                                worksheet.Cells[$"E{i + 4}"].PutValue(tels[i]);
                            }
                            break;
                        case "email":
                            var emails = _db.TblApplicants.Select(a => a.Email).ToList();
                            for (int i = 0; i < emails.Count; i++)
                            {
                                worksheet.Cells[$"F{i + 4}"].PutValue(emails[i]);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            var stream = new MemoryStream();
            workbook.Save(stream, SaveFormat.Xlsx);

            // Return the file as a download
            var fileName = "Sample.xlsx";
            var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            stream.Position = 0;
            var file = File(stream, contentType, fileName);
            return file;
        }
    }
}
