using Microsoft.AspNetCore.Mvc;
using RainBowAssociations.Models;

namespace RainBowAssociations.Controllers
{
    public class TeachersController : Controller
    {
        static List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher(){EmpId=100,TeacherName="Lakshmi",Address="Rjy"},
            new Teacher(){EmpId=101,TeacherName="Lakshman",Address="Pune"},
            new Teacher(){EmpId=102,TeacherName="Rohith",Address="Ndd"},
            new Teacher(){EmpId=103,TeacherName="Andryana",Address="North Koriea"},
        };
        public IActionResult Index()
        {
            return View(teachers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Teacher());
        }
        [HttpPost]
        public IActionResult Create(Teacher model)
        {
            if (ModelState.IsValid)
            {
                teachers.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
