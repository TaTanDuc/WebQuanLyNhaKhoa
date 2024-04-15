﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebQuanLyNhaKhoa.Data;

namespace WebQuanLyNhaKhoa.Controllers.HomePageCustomer
{
    public class BookAppointmentController : Controller
    {
        private readonly QlnhaKhoaContext _context;

        public BookAppointmentController(QlnhaKhoaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BenhNhan benhNhan)
        {
            var count = _context.BenhNhans.Count() + 1;
                    benhNhan.IdbenhNhan = count.ToString();
                    _context.BenhNhans.Add(benhNhan);
                    _context.SaveChanges();
            return RedirectToAction("Index","Home");
        }


    }
}
