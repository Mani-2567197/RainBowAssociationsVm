using Microsoft.AspNetCore.Mvc;
using RainBowAssociations.Models;

namespace RainBowAssociations.Controllers
{
    public class StudentsController : Controller
    {
        static List<Student> students = new List<Student>()
        {
            new Student(){StudentId = 1,StudentName="Ram",Address="Hyd",StudentAge=16,StudentEmail="ram@yahoo.com"},
            new Student(){StudentId = 2,StudentName="Sumith",Address="Hyd",StudentAge=17,StudentEmail="sumith@yahoo.com"},
            new Student(){StudentId = 3,StudentName="Lokesh",Address="Hyd",StudentAge=16,StudentEmail="lokesh@yahoo.com"},
            new Student(){StudentId = 4,StudentName="Lohith",Address="Hyd",StudentAge=15,StudentEmail="lohith@yahoo.com"},
            new Student(){StudentId = 5,StudentName="Sushma",Address="Hyd",StudentAge=16,StudentEmail="sushma@yahoo.com"},
        };
        public IActionResult Index()
        {
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Student());
        }
        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                students.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
