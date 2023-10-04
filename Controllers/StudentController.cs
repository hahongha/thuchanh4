using Microsoft.AspNetCore.Mvc;

namespace Labb4.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create() { 
            
            return View();
        }
    }
}
