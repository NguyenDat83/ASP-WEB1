using Microsoft.AspNetCore.Mvc;

namespace BaiTapVeNha2.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Nguyễn Quốc Đạt";
            ViewBag.MSSV = "1822041217";
            ViewData["Nam"] = "Năm 2024";
            return View();
        }
    }
}
