using Microsoft.AspNetCore.Mvc;
using StudentsCrud.Data;
using StudentsCrud.Models;

namespace StudentsCrud.Controllers
{
    public class StudentController :Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context =context ;
        }

        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("index");
            
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }

            _context.Students.Update(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var s = _context.Students.Find(id);
            if (s == null)
            {
                return NotFound();
            }

            _context.Students.Remove(s);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
