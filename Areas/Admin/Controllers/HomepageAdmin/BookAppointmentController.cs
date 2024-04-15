using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebQuanLyNhaKhoa.Data;
using WebQuanLyNhaKhoa.Models;

namespace WebQuanLyNhaKhoa.Area.Admin.Controllers.HomepageAdmin
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class BookAppointmentController : Controller
    {
        private readonly QlnhaKhoaContext _context;

        public BookAppointmentController(QlnhaKhoaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(BenhNhan benhNhan)
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
