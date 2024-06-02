using Azmoon.Models;
using Microsoft.AspNetCore.Mvc;

namespace Azmoon.Controllers
{
    public class AzmoonTestController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AzmoonTestController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult AzmoonIndex() => View();

        public IActionResult GetAllDatas()
        {
            var result = _db.TblApplicants.ToList();
            return View(result);
        }
    }
}
