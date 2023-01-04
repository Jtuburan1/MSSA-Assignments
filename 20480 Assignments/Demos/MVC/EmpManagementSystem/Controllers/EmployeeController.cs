using Microsoft.AspNetCore.Mvc;
using EmpManagementSystem.Services;
using EmpManagementSystem.Models;

namespace EmpManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private ICRUD cRUD;
        private IFileUpload fileUpload;
        public EmployeeController(ICRUD cRUD, IFileUpload fileUpload)
        {
            this.cRUD = cRUD;
            this.fileUpload = fileUpload;
        }

        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Employees = cRUD.GetEmployees();
            return View(model);
        }

        public IActionResult About()
        {
            return View();
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

        public IActionResult Edit(int? id)
        {
            var empToEdit = cRUD.GetEmployee(id);
            return View(empToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
            if(ModelState.IsValid)
            {
                cRUD.UpdateEmployee(obj);
                return RedirectToAction("Index");
            }
            ViewBag.ErrorMessage = "Employee was not updated.";
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            cRUD.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

        // This is your http get request
        public IActionResult Create()
        {
            var empNew = new Employee();
            empNew.Id = cRUD.GetMaxID();
            return View(empNew);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Employee obj, IFormFile file)
        {
            if(ModelState.IsValid)
            {
                if(await fileUpload.UploadFile(file))
                {
                    obj.ImageName = fileUpload.FileName;
                    cRUD.AddEmployee(obj);
                    return RedirectToRoute(new { action = "Index", controller = "Employee" });
                }
                else
                {
                    ViewBag.ErrorMessage = "File upload failed.";
                    return View(obj);
                }
            }
            ViewBag.Message = "Error adding employee to the database.";
            return View(obj);
        }
    }
}
