using Microsoft.AspNetCore.Mvc;
using RainBowAssociations.Models;

namespace RainBowAssociations.Controllers
{
    public class SubjectsController : Controller
    {
        static List<Subject> subjects=new List<Subject>()
        {
            new Subject(){Subjectcode=101,SubjectName="Maths",SubjectTeacher="Lakshmi"},
             new Subject(){Subjectcode=102,SubjectName="Physics",SubjectTeacher="Lakshman"},
              new Subject(){Subjectcode=103,SubjectName="Chemistry",SubjectTeacher="Rohith"},
               new Subject(){Subjectcode=104,SubjectName="english",SubjectTeacher="Andriyana"},
        };
        public IActionResult Index()
        {
            return View(subjects);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Subject());
        }
        [HttpPost]
        public IActionResult Create(Subject model)
        {
            if (ModelState.IsValid)
            {
                subjects.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
