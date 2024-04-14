using Microsoft.AspNetCore.Identity;

namespace WebQuanLyNhaKhoa.Models
{
    public class RoleVM : IdentityRole
    {
        public RoleVM(string roleName) : base(roleName)
        {
            TenCv = roleName;
        }

        public string MaCv { get; set; }

        public string TenCv { get; set; }
    }
}
