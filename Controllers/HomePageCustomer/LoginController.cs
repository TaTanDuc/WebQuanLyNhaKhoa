using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WebQuanLyNhaKhoa.Data;
using WebQuanLyNhaKhoa.Models;

namespace WebQuanLyNhaKhoa.Controllers.HomePageCustomer
{
    public class LoginController : Controller
    {
		private readonly QlnhaKhoaContext _context;

		public LoginController(QlnhaKhoaContext context)
		{
			_context = context;
		}

		public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public IActionResult Index(LoginVM model)
		{
            if (ModelState.IsValid)
            {
                var user = _context.NhanViens.Include(u => u.TenDangNhapNavigation).SingleOrDefault(u => u.TenDangNhap == model.TenDangNhap);
                /*if (user == null)
                {
                    ModelState.AddModelError("Error:", "Không tồn tại người dùng này!");
                }
                else
                {
                    if (user.TenDangNhapNavigation.MatKhau != model.MatKhau)
                    {
                        ModelState.AddModelError("Error:", "Sai mật khẩu!");
                    }
                    else
                    {
                        if (user.MaCv.Contains("AD"))
                        {
                            SignIn(new ClaimsPrincipal(
                                    new ClaimsIdentity(
                                        new Claim[] {
                                                new Claim("myAdmin","Admin")
                                            },
                                                "cookie",
                                                nameType: null,
                                                roleType: "myAdmin"
                                        )
                                    ),
                                    authenticationScheme: "cookie"
                                );
                            return RedirectToAction("Index", "Home", new { area = "Admin" });
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }

                    }
                }*/

                if (user != null)
					{
						Formauthen.SetAuthCookie(model.UserName, false);
						return RedirectToAction("Index", "Home");
					}
					else
					{
						ModelState.AddModelError("", "Invalid username or password.");
					}
			}
            return View();
        }
    }
}
