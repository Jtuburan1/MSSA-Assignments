using Microsoft.AspNetCore.Mvc;
using Mod4Demo.Models;
using System.Diagnostics;

namespace Mod4Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IEnumerable<Person> ReturnData()
        {
            Stack<Person> result = new Stack<Person>();
            result.Push(new Person() { ID = 101, Name = "abc" });
            result.Push(new Person() { ID = 102, Name = "def" });
            return result;
        }

        public IActionResult Display()
        {
            Person person = new Person();
            person.ID = 101;
            person.Name = "Joe";
            ViewBag.servertime = DateTime.Now.ToString();
            ViewData["data"] = "some server side data";
            ViewData["temp"] = 34.5;
            return View(person);
        }

        // returns viewresult
        public ViewResult Index()
        {
            return View();
        }

        // return content result
        public ContentResult ReturnContent()
        {
            return Content("Hello");
        }

        public RedirectToActionResult Method1()
        {
            string nameOfMethod = "Privacy";
            return RedirectToAction(nameOfMethod);
        }

        // Status Code (used in web apis)
        public StatusCodeResult Method2()
        {
            //logic
            return new StatusCodeResult(404);
        }

        public ContentResult Test(string param)
        {
            return Content("Value in route parameter: " + param);
        }

        // redirect result
        public RedirectResult OpenGoogle()
        {
            return Redirect("http://www.google.com");
        }

        public IActionResult Privacy()
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