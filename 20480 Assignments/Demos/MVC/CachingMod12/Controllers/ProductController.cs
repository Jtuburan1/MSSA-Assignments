using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CachingMod12.Repositories;

namespace CachingMod12.Controllers 
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index(int? id)
        {
            var products = _repository.GetProducts();
            ViewBag.SelectedProductId = id;
            return View(products);
        }

        public IActionResult GetImage(string name)
        {
            return File($@"images\{name}.png", "image/png");
        }
    }
}