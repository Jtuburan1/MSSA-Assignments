using Microsoft.AspNetCore.Mvc;
using ProductManagementSystem.Models;
using ProductManagementSystem.Services;

namespace ProductManagementSystem.Controllers
{
    public class TeaController : Controller
    {
        private ITeaRepository teaReposit;
        private IFileUpload fileUpload;
        // dependency injection/constructor
        public TeaController(ITeaRepository teaReposit, IFileUpload fileUpload)
        {
            this.teaReposit = teaReposit;
            this.fileUpload = fileUpload;
        }

        public IActionResult About()
        {
            return View();
        }

        // takes you to index view
        public IActionResult Index()
        {
            IndexViewModel teas = new IndexViewModel();
            teas.Tea = teaReposit.GetAllTeas();
            return View(teas);
        }

        // takes you to details view
        public IActionResult Details(int? id)
        {
            var tea = teaReposit.GetTea(id);
            if(tea == null)
            {
                return NotFound();
            }
            return View(tea);
        }

        // Get portion of the create action. Takes you to the Create View
        public IActionResult Create()
        {
            var teaNew = new Tea();
            teaNew.Id = teaReposit.GetMaxID();
            return View(teaNew);
        }

        // Post portion of the create action. Saves the created tea if it is valid and takes you back to the Index page. if it is not valid it will keep you on the "Create" form.
        [HttpPost]
        public async Task<ActionResult> Create(Tea obj, IFormFile file)
        {
            if(ModelState.IsValid)
            {
                if(await fileUpload.UploadFile(file))
                {
                    obj.ImageName = fileUpload.FileName;
                    teaReposit.AddTea(obj);
                    return RedirectToRoute(new { action = "Index", controller = "Tea" });
                }
                else
                {
                    ViewBag.ErrorMessage = "File upload failed.";
                    return View(obj);
                }
            }
            ViewBag.Message = "Error adding tea to the database.";
            return View(obj);
        }

        // Takes the id of the Tea you clicked and sends it to your edit view so you can change it.
        public IActionResult Edit(int? id)
        {
            var teaToEdit = teaReposit.GetTea(id);
            return View(teaToEdit);
        }

        // After you submit the changes, it attempts to upload any changed files and if not then it will send the updates to the collection
        [HttpPost]
        public async Task<ActionResult> Edit(Tea obj, IFormFile file)
        {
            if (file == null)
            {
                teaReposit.UpdateTea(obj);
                return RedirectToRoute(new { action = "Index", controller = "Tea" });
            }
            if (ModelState.IsValid)
            {
                if (await fileUpload.UploadFile(file))
                {
                    obj.ImageName = fileUpload.FileName;
                    teaReposit.UpdateTea(obj);
                    return RedirectToRoute(new { action = "Index", controller = "Tea" });
                }
                else
                {
                    ViewBag.ErrorMessage = "File upload failed.";
                    return View(obj);
                }
            }
            ViewBag.Message = "Error updating the selected tea on the database.";
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            teaReposit.DeleteTea(id);
            return RedirectToAction("Index");
        }
    }
}
