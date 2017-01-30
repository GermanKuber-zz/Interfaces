using System;
using System.Collections.Generic;
using System.Linq;
using Peoples.Repositories.Interface;

namespace Peoples.Service.Test
{
    //TODO : 11 - Creo un Mock de mi repositorio de Peoples
    public class MockPeopleRepository : IPeopleRepository
    {
        private readonly List<Person> _context;

        public MockPeopleRepository()
        {
            _context = new List<Person>();


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