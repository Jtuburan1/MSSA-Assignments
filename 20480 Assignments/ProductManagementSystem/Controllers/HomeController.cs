using Microsoft.AspNetCore.Mvc;
using ProductManagementSystem.Models;
using System;
using System.Diagnostics;
using System.Net.Http;

namespace ProductManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHttpClientFactory httpClientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            this.httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            //int x = 0;
            //int result = 30 / x;
            return View();
        }

        public IActionResult Display()
        {
            HttpClient httpClient = httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:5046");
            var response = httpClient.GetFromJsonAsync<List<Employee>>("http://localhost:5046/api/Employee");

            List<Employee> people = response.Result;
            return View(people);
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