using IDT.Data;
using IDT.Models;
using Microsoft.AspNetCore.Mvc;

namespace IDT.Controllers
{
    public class ScanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScanController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SaveScanData(string lotNo, string size, string remarks)
        {
            var data = new ScanData
            {
                LotNo = lotNo,
                Size = size,
                Remarks = remarks
            };

            _context.ScanDatas.Add(data);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}
