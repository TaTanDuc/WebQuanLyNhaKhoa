using AutoMapper;
using WebQuanLyNhaKhoa.Data;
using WebQuanLyNhaKhoa.Models;

namespace WebQuanLyNhaKhoa.wwwroot.AutoMapper
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile() 
		{
			CreateMap<RegisterVM, TaiKhoan>();

			CreateMap<NhanVienVM, NhanVien>();
		}
	}
}
