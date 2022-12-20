using Microsoft.AspNetCore.Mvc;
using Mod3Demo.Models;
using Mod3Demo.Services;
using System.Diagnostics;

namespace Mod3Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRandom random;

        public HomeController(ILogger<HomeController> logger, IRandom random)
        {
            this.random = random;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display()
        {
            ViewBag.number = random.GetNumber();
            return View();
        }

        public ContentResult Hello()
        {
            return Content("Hello!");
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