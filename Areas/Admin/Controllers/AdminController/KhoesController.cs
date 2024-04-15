﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebQuanLyNhaKhoa.Data;
using WebQuanLyNhaKhoa.Models;

namespace WebQuanLyNhaKhoa.Area.Admin.Controllers.AdminController
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class KhoesController : Controller
    {
        private readonly QlnhaKhoaContext _context;

        public KhoesController(QlnhaKhoaContext context)
        {
            _context = context;
        }

        // GET: Khoes
        public async Task<IActionResult> Index()
        {
            var qlnhaKhoaContext = _context.Khos.Include(k => k.IdsanPhamNavigation);
            return View(await qlnhaKhoaContext.ToListAsync());
        }

    }
}
