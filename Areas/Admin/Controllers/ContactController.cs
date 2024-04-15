using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebQuanLyNhaKhoa.Models;

namespace WebQuanLyNhaKhoa.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
