using Microsoft.AspNetCore.Mvc;

namespace project1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public int myname(int id)
        {
            return id;
        }
    }
}
