using EmployeeAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> employees;
        public EmployeeController()
        {
            employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, Name = "Whitney", Job = "Owner", Salary = 70000 });
            employees.Add(new Employee { Id = 2, Name = "Joe", Job = "IT", Salary = 50000 });
            employees.Add(new Employee { Id = 3, Name = "Rae", Job = "Server", Salary = 40000 });
            employees.Add(new Employee { Id = 4, Name = "Rheannon", Job = "Manager", Salary = 60000 });
            employees.Add(new Employee { Id = 5, Name = "Ashley", Job = "Chef", Salary = 45000 });
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeByID(int? id)
        {
            var person = employees.Find(x => x.Id == id);
            if(person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
