using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Peoples.Repositories.Interface;
using Peoples.Repositories.Service;

namespace People.ExternalService.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        static readonly IPeopleRepository PeopleRepo = new PeopleExternalRepository();
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Person>), 200)]
        public IEnumerable<Person> Get()
        {
            return PeopleRepo.GetPeople();
        }
        [HttpGet("{lastName}")]
        [ProducesResponseType(typeof(Person), 200)]
        public Person Get(string lastName)
        {
            return PeopleRepo.GetPeople().FirstOrDefault(x => x.LastName == lastName);
        }

        [HttpPost]
        public void Post([FromBody]Person value)
        {
            PeopleRepo.AddPerson(value);
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{lastname}")]
        public void Delete(string lastname)
        {
            PeopleRepo.DeletePerson(lastname);
        }
    }
}