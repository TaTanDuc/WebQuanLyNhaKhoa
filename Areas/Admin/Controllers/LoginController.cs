using Microsoft.AspNetCore.Mvc;

namespace WebQuanLyNhaKhoa.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class LoginController : Controller
    {
        public LoginController() { }
                
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
