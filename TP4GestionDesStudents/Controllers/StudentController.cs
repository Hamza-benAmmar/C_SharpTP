using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP4GestionDesStudents.Data;
using TP4GestionDesStudents.Models;

namespace TP4GestionDesStudents.Controllers
{
    public class StudentController : Controller
    {
        [Route("Student/UniqueCourses")]
        public IActionResult UniqueCourses()
        {
            IStudentRepository students = new StudentRepository(UniversityContext.Instance);
            //ViewBag.Courses = students.GetUniqueCourses();
            return View(students.GetUniqueCourses());
        }

        // GET: Student
        public IActionResult Index()
        {
            UniversityContext u = UniversityContext.Instance;
            List<Student> s = u.Student.ToList();
            return View(s);
        }
        [Route("Student/StudentByCourse/{Course}")]
        public IActionResult StudentByCourse(string course)
        {
            StudentRepository students = new StudentRepository(UniversityContext.Instance);
            return View(students.StudentsByCourse(course));
        }
        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
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

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
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

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
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
