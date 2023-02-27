using Microsoft.AspNetCore.Mvc;
using DemoEntNetBranching.Models;
namespace DemoEntNetBranching.Controllers
{
    public class StudentController : Controller
    {
        
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            students = StudentDB.GetStudents();
            return View(students);
        }



        [Route("Student/Detail/{LastName}")]
        public IActionResult Detail(string lastName)
        {
            Student student = StudentDB.getStudentByLastName(lastName);
            return View(student);

        }
    }
}
