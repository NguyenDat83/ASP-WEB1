using BaiKiemTra03_03.Data;
using BaiKiemTra03_03.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra03_03.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CustomerController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var customer = _db.Customer.ToList();
            ViewBag.Customer = customer;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                // thêm thông tin vào bảng theloai
                _db.Customer.Add(customer);
                //Luu lại
                _db.SaveChanges();
            }
            return View();
        }
		[HttpGet]

		public IActionResult Edit(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var customer = _db.Customer.Find(id);
			return View(customer);
		}
		[HttpPost]
		public IActionResult Edit(Customer customer)
		{
			if (ModelState.IsValid)
			{
				// thêm thông tin vào bảng theloai
				_db.Customer.Update(customer);
				//Luu lại
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}
		public IActionResult Delete(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var customer = _db.Customer.Find(id);
			return View(customer);
		}
		[HttpPost]
		public IActionResult DeleteConfirm(int id)
		{
			var customer = _db.Customer.Find(id);
			if (customer == null)
			{
				return NotFound();
			}
			_db.Customer.Remove(customer);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}
		[HttpGet]

		public IActionResult Details(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var customer = _db.Customer.Find(id);
			return View(customer);
		}
		[HttpPost]
		public IActionResult Details(Customer customer)
		{
			if (ModelState.IsValid)
			{
				// thêm thông tin vào bảng theloai
				_db.Customer.Update(customer);
				//Luu lại
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return RedirectToAction("Index");
		}
		[HttpGet]

		public IActionResult Search(string searchString)
		{
			if (!string.IsNullOrEmpty(searchString))
			{
				//Sử dụng LINQ để tìm kiếm
				var customer = _db.Customer.Where(tl => tl.customer_name.Contains(searchString)).ToList();

				ViewBag.SearchString = searchString;
				ViewBag.Customer = customer;

			}
			else
			{
				var customer = _db.Customer.ToList();
				ViewBag.TheLoai = customer;
			}

			return View("Index");//Sử dụng lại view INdex
		}
	}
}
