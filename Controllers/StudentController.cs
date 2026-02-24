using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneWebApp.Models;

namespace PhoneWebApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(int accessLevel)
        {
            var studentList = new List<Student> {
                new Student { firstName = "John", lastName = "Smith", grade = 93 },
                new Student { firstName = "Emma", lastName = "Johnson", grade = 75 },
                new Student { firstName = "Liam", lastName = "Brown", grade = 85 },
                new Student { firstName = "Olivia", lastName = "Davis", grade = 64 },
                new Student { firstName = "Noah", lastName = "Miller", grade = 50 }
            };
            var model = new StudentViewModel
            {
                AccessLevel = accessLevel,
                Students = studentList
            };

            return View(model);
        }
    }
}
