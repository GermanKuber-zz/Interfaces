using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Peoples.Repositories.Interface;
using Peoples.Repository.Memory;

namespace People.ExternalService.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        static readonly IPeopleRepository PeopleRepo = new PeopleRepositoryInMemory();
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Person>), 200)]
        [AllowAnonymous]
        public IEnumerable<Person> Get()
        {
            var list = PeopleRepo.GetPeople();
            foreach (var person in list)
                person.LastName = $"{person.LastName} - By Api Rest Service";

            return list;
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