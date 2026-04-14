using Microsoft.AspNetCore.Mvc;
using QuanLySinhVien.Data;
using QuanLySinhVien.Models;

namespace QuanLySinhVien.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db) { _db = db; }

        public IActionResult Index()
        {
            var students = _db.Students.ToList();
            return View(students);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}