
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Courses()
        {
            return View();
        }


        public IActionResult Detail()
        {

            return View();
        }

    }
}