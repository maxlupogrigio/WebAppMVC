
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models.Services.Application;
using WebAppMVC.Models.ViewModels;

namespace WebAppMVC.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Courses()
        {
           
           var courseService = new CourseService();
           List<CourseViewModel> courses =  courseService.GetServices();

            return View(courses);
        }


        public IActionResult Detail(int id)
        {

            return View();
        }

    }
}