using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemoMod13.Models;

namespace WebAPIDemoMod13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Produces("application/xml")]
    public class PersonController : ControllerBase
    {
        private List<Person> people;

        public PersonController()
        {
            people = new List<Person>();
            people.Add(new Person { Id = 1, Name = "Joe", Age = 29, City = "Beaufort" });
            people.Add(new Person { Id = 2, Name = "Alex", Age = 28, City = "Mendota" });
            people.Add(new Person { Id = 3, Name = "Joma", Age = 24, City = "New York" });
        }

        [HttpGet("{id}")]
        public ActionResult<Person> GetPersonByID(int? id)
        {
            var person = people.Find(x => x.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpGet]
        public List<Person> GetPeople()
        {
            return people;
        }
    }
}
