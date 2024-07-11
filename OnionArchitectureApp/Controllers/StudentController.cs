using DomainLayer.Entities;
using DomainLayer.Interfaces;
using System.Web.Mvc;

namespace OnionArchitectureApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: Student/Details/1
        public ActionResult Details(int id)
        {
            var student = _studentService.GetStudent(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Student/AddNewStudent
        public ActionResult AddNewStudent()
        {
            return View();
        }

        // POST: Student/AddNewStudent
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddNewStudent(Students student)
        {
            if (ModelState.IsValid)
            {
                // Save the student
                _studentService.AddStudent(student); // Ensure this method is implemented in IStudentService and StudentService
                return RedirectToAction("Index", "Home"); // Redirect to a suitable page
            }
            return View(student);
        }
    }
}
