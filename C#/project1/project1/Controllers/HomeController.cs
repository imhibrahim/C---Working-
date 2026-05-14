using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project1.Models;

namespace project1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int detail(int id)
        {
            return id ;
        }
        public String details(String id)
        {
            return id;
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult gallary()
        {
            return View();
        }


        public IActionResult practice()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
