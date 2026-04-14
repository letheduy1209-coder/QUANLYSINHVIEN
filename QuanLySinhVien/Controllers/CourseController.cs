using Microsoft.AspNetCore.Mvc;
using QuanLySinhVien.Data;
using QuanLySinhVien.Models;

namespace QuanLySinhVien.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CourseController(ApplicationDbContext db) { _db = db; }

        // Trang hiện danh sách khóa học
        public IActionResult Index()
        {
            var list = _db.Courses.ToList();
            return View(list);
        }

        // Trang để bấm vào thêm khóa học
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Course obj)
        {
            _db.Courses.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}