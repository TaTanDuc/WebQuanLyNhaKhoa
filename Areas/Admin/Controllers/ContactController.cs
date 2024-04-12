using Microsoft.AspNetCore.Mvc;

namespace WebQuanLyNhaKhoa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
