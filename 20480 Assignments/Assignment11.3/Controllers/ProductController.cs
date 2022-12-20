using Microsoft.AspNetCore.Mvc;
using Assignment11._3.Services;
using Assignment11._3.Models;

namespace Assignment11._3.Controllers
{
    public class ProductController : Controller
    {
        private ICRUD _products;
        public ProductController(ICRUD cRUD)
        {
            this._products = cRUD;
        }
        public IActionResult Display()
        {
            IndexViewModel prod = new IndexViewModel();
            prod.Products = _products.GetProducts();
            return View(prod);
        }
    }
}
