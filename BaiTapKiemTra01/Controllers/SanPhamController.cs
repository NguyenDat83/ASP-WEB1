using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult BaiTap2(SanPhamViewModel SanPham)
        {
            var sanpham = new SanPhamViewModel()
            {
                tensanpham = "Dien Thoai",
                giaban = "20.000.000",
                anhmota= "/images/DienThoai.jpg"

            };
            return View(sanpham);
        }
    }
}
