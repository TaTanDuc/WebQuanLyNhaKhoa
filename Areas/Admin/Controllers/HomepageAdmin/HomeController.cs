using WebQuanLyNhaKhoa.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using WebQuanLyNhaKhoa.Data;
using Microsoft.EntityFrameworkCore;

namespace WebQuanLyNhaKhoa.Area.Admin.Controllers.AdminController
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly QlnhaKhoaContext _context;

        public HomeController(QlnhaKhoaContext context)
        {
            _context = context;
        }

        // GET: Home
        public async Task<IActionResult> Index()
        {
            int Experienced = 10;
            var qlnhaKhoaContext = _context.NhanViens.Where(n => n.KinhNghiem > Experienced).Take(4);
            return View(await qlnhaKhoaContext.ToListAsync());
        }
        private async Task<string> SaveImage(IFormFile image)
        {
            var savePath = Path.Combine("wwwroot/images", image.FileName);
            using (var fileStream = new FileStream(savePath, FileMode.Create))
            {
                await image.CopyToAsync(fileStream);
            }
            return "/images/" + image.FileName;
        }
        public IActionResult BookAppointment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BookAppointment(BenhNhan benhNhan)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    _context.BenhNhans.Add(benhNhan);
                    _context.SaveChanges();
                }
            }
            return View(benhNhan);
        }
    }
}
