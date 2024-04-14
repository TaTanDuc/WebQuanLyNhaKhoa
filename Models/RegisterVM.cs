﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebQuanLyNhaKhoa.Data;

namespace WebQuanLyNhaKhoa.Models
{
    public class RegisterVM
    {	
		[MinLength(5,ErrorMessage = "Không ít hơn 5 ký tự!")]
        [MaxLength(20)]
        [Remote(action: "VerifyUserName",controller: "RegisterController")]
        [Required(ErrorMessage ="Trường này không được bỏ trống!")]
		public string? TenDangNhap { get; set; }

        [MaxLength(20)]
        [MinLength(5, ErrorMessage = "Mật khẩu quá ngắn!")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Trường này không được bỏ trống!")]
		public string? MatKhau { get; set; }
	}
}
