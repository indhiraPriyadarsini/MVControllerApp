using Microsoft.AspNetCore.Mvc;
namespace MVControllerApp.Models {
    namespace MVControllerApp.Controllers
    {
        [Route("[controller]")]
        public class StudentController : Controller
        {
            [Route("student")]
            public IActionResult Index()
            {
                return View();
            }

            [Route("studentDetails")]
            public IActionResult StudentDetails()
            {
                List<StudentModel> students = studentDetails();
                return View(students);
            }
            private  List<StudentModel> studentDetails()
            {
                List<StudentModel> students = new();
                var student1 = new StudentModel();
                student1.StudentId = 1;
                student1.StudentName = "indra";
                student1.Age = 21;
                student1.Department = "ECE";
                students.Add(student1);
                var student2 = new StudentModel();
                student2.StudentId = 2;
                student2.StudentName = "kavi";
                student2.Age = 22;
                student2.Department = "ECE";
                students.Add(student2);
                var student3 = new StudentModel();
                student3.StudentId = 3;
                student3.StudentName = "jeeva";
                student3.Age = 21;
                student3.Department = "CS";
                students.Add(student3);

                return students;
            }

        }
    }
}