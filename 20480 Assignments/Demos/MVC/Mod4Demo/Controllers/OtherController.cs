using Microsoft.AspNetCore.Mvc;

namespace Mod4Demo.Controllers
{
    public class OtherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //attribute based routing
        [Route("/BestRestaurants")]
        public ContentResult DisplayRestaurants()
        {
            return Content("sample text");
        }

        [Route("/Print/{fname}/{lname}")]
        public IActionResult PrintName(string fname, string lname)
        {
            return Content("Hello " + fname + " " + lname);
        }
    }
}
