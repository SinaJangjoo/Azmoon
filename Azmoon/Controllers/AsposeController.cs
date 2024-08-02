using Aspose.Cells;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using static Azure.Core.HttpHeader;

namespace Azmoon.Controllers
{
    [Route("api/Aspose")]
    [ApiController]
    public class AsposeController : ControllerBase
    {
        [HttpPost("export")]
        public IActionResult ExportToExcel([FromBody] List<string> data)
        {

            var workbook = new Workbook();
            var worksheet = workbook.Worksheets[0];


            for (int i = 0; i < data.Count; i++)
            {
                worksheet.Cells[$"A{i + 2}"].PutValue(data[i]);
                worksheet.Cells[$"B{i + 2}"].PutValue(i + 1);
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
