using WebQuanLyNhaKhoa.Data;

namespace WebQuanLyNhaKhoa.Models
{
    public class RoleVM
    {
        public string MaCv { get; set; } = null!;

        public string TenCv { get; set; } = null!;

        public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
    }
}
