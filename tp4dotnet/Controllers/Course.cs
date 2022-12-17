using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tp4dotnet.Data;
using tp4dotnet.Models;

namespace tp4dotnet.Controllers
{
    public class Course : Controller
    {
        // GET: Course
        public ActionResult Index()
        {

            StudentRepository studentRepository = new StudentRepository();
            foreach (String s in studentRepository.GetCourses())
                Debug.WriteLine(s);

            return View(studentRepository.GetCourses());
        }

        public IActionResult GetCourse(string id)
        {
            StudentRepository studentRepository = new StudentRepository();
            IEnumerable<Student> res = (IEnumerable<Student>)studentRepository.Find(v => v.course.ToLower() == id.ToLower());
           
            if (res.Count() != 0) ViewBag.Id = res.First().course;
            return View(res);
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Course/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Course/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
