using Microsoft.AspNetCore.Mvc;
using project1.Models;

namespace project1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<StudentModel>
            {
                new StudentModel{ id=101,name="Ibrahim",gander="Male",standerd=4,},
                  new StudentModel{ id=102,name="Khixzer",gander="Male",standerd=5,},
                    new StudentModel{ id=103,name="maira",gander="Female",standerd=5,},
                      new StudentModel{ id=104,name="mahnoor",gander="Female",standerd=4,}
            };

            //ViewData["stddata"] = students;
            //TempData["stddata"] = students;
            //ViewBag.data = students;

            return View(students);
        }

        public int user(int id)
        {
            return id;
        }
    }
}
