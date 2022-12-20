using Microsoft.AspNetCore.Mvc;
using Mod3Demo.Services;

namespace Mod3Demo.Controllers
{
    public class ProductController : Controller
    {
        private IRandom random;

        public ProductController(IRandom random)
        {
            this.random = random;
        }

        public IActionResult Index() //default method, can keep or remove without affecting anything
        {
            return View();
        }
        public IActionResult Display()
        {
            return Content(random.GetNumber().ToString());
        }
    }
}
