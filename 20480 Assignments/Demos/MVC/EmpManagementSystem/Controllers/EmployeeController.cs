using Microsoft.AspNetCore.Mvc;
using EmpManagementSystem.Services;
using EmpManagementSystem.Models;

namespace EmpManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private ICRUD cRUD;
        public EmployeeController(ICRUD cRUD)
        {
            this.cRUD = cRUD;
        }
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Employees = cRUD.GetEmployees();
            return View(model);
        }
        public IActionResult Details(int? id)
        {
            var emp = cRUD.GetEmployee(id);
            if(emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }
    }
}
