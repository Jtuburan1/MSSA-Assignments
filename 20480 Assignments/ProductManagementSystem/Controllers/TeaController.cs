using Microsoft.AspNetCore.Mvc;
using ProductManagementSystem.Models;
using ProductManagementSystem.Services;

namespace ProductManagementSystem.Controllers
{
    public class TeaController : Controller
    {
        private ITeaRepository teaReposit;
        public TeaController(ITeaRepository teaReposit)
        {
            this.teaReposit = teaReposit;
        }

        public IActionResult Index()
        {
            IndexViewModel teas = new IndexViewModel();
            teas.Tea = teaReposit.GetAllTeas();
            return View(teas);
        }
        public IActionResult Details(int? id)
        {
            var tea = teaReposit.GetTea(id);
            if(tea == null)
            {
                return NotFound();
            }
            return View(tea);
        }
    }
}
