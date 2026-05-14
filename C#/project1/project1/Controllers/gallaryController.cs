using Microsoft.AspNetCore.Mvc;

namespace project1.Controllers
{
    public class gallaryController : Controller
    {
        public IActionResult shop()
        {
            ViewData["name"] = "Muhammad Ibrahim";
            ViewData["name1"] = DateTime.Now.ToLongDateString();
            String[] data = ["Ibrahim", "Hurram", "Subhan"];
            ViewData["data"] = data;
            ViewBag.name2 = new List<string>()
            {
                "Html","Css","Bootstrap"
            };
            ViewBag.username = "Ibrahim";
            return View();
        }
    }
}
