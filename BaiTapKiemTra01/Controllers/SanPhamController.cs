﻿using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult BaiTap2()
        {
            var sanpham = new SanPhamViewModel();
            return View();
        }
    }
}
