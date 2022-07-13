using Microsoft.AspNetCore.Mvc;

namespace MVControllerApp.Controllers {
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        [Route ("indhira")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("presidio")]
        public IActionResult GetEmployee()
        {
            return View();
        }

    }
}
