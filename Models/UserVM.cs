using Microsoft.AspNetCore.Identity;
using NuGet.Packaging;
using WebQuanLyNhaKhoa.Data;

namespace WebQuanLyNhaKhoa.Models
{
    public class UserVM : IdentityUser
    {
        public int MaNv { get; set; }

        public string? TenDangNhap { get; set; }

        public string? Ten { get; set; }

        public string? Sdt { get; set; }

        public string MaCv { get; set; }

        public string? KinhNghiem { get; set; }

        public string? Hinh { get; set; }
    }
}
