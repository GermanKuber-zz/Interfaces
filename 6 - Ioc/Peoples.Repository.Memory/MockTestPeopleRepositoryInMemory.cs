using System;
using System.Collections.Generic;
using Peoples.Repositories.Interface;
using System.Linq;

namespace Peoples.Repository.Memory
{
    public class MockTestPeopleRepositoryInMemory : IPeopleRepository
    {
        private readonly List<Person> _context;

        public MockTestPeopleRepositoryInMemory()
        {
            _context = new List<Person>
            {
                new Person()
                {
                    FirstName = "Mock Test",
                    LastName = "Mock Test",
                    StartDate = new DateTime(1975, 10, 19),
                    Rating = 6
                }
            };

        }
        public IEnumerable<Person> GetPeople()
        {
            return _context;
        }

        public Person GetPerson(string lastName)
        {
            Person selPerson = _context.FirstOrDefault(s => s.LastName == lastName);
            return selPerson;
        }

        public void AddPerson(Person newPerson)
        {
            _context.Add(newPerson);
        }
        public void DeletePerson(string lastName)
        {
            var itemDel = _context.FirstOrDefault(x => x.LastName == lastName);
            if (itemDel != null)
                _context.Remove(itemDel);
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }

        public void UpdatePeople(IEnumerable<Person> updatedPeople)
        {
            throw new NotImplementedException();
        }
    }
}