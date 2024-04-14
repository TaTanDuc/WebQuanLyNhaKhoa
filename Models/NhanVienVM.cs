namespace WebQuanLyNhaKhoa.Models
{
	public class NhanVienVM
	{
		public int MaNv { get; set; }

		public string TenDangNhap { get; set; } = null!;

		public string Ten { get; set; } = null!;

		public string? Sdt { get; set; }

		public string MaCv { get; set; } = null!;

		public string? KinhNghiem { get; set; }

		public string? Hinh { get; set; }
	}
}
