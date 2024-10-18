using BaiKiemTra03_03.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace BaiKiemTra03_03.Controllers
{
    public class ContractController : Controller
    {
		private readonly ApplicationDbContext _db;
		public ContractController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
        {

			IEnumerable<Contract> sanpham = _db.Contract.Include("TheLoai").ToList();
			return View(sanpham);
		}
    }
}
