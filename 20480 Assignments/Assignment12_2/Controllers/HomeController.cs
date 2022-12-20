using Assignment12_2.Models;
using Assignment12_2.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment12_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICRUD cRUD;

        public HomeController(ILogger<HomeController> logger, ICRUD cRUD)
        {
            _logger = logger;
            this.cRUD = cRUD;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Books()
        {
            IndexViewModel books = new IndexViewModel();
            books.Books = cRUD.GetBooks();
            return View(books);
        }

        public IActionResult Details(int? id)
        {
            var book = cRUD.GetBook(id);
            if(book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        public IActionResult About()
        {
            return View();
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