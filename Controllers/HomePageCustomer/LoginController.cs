using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebQuanLyNhaKhoa.Data;
using WebQuanLyNhaKhoa.Models;

namespace WebQuanLyNhaKhoa.Controllers.HomePageCustomer
{
    public class LoginController : Controller
    {
		private readonly QlnhaKhoaContext _context;
        public LoginController() { }
                
        public async Task<IActionResult> Index()
        {
            return View();
        }

		[HttpPost]
		public IActionResult Index(LoginVM model)
		{
			if (_context.NhanViens.SingleAsync(u => u.TenDangNhap == model.TenDangNhap) != null)
			{
				return RedirectToAction("Index", "Home");
			}
			return View();
		}
	}
}
