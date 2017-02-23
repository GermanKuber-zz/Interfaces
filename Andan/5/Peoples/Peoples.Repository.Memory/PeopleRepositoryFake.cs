using System;
using System.Collections.Generic;
using System.Linq;
using Peoples.Repositories.Interface;

namespace Peoples.Repository.Memory
{
    //TODO : 07 - Implemento un repositorio Fake
    public class PeopleRepositoryFake : IPeopleRepository
    {
        private readonly List<Person> _context;

        public PeopleRepositoryFake()
        {
            _context = new List<Person>
            {
                new Person()
                {
                    FirstName = "Germán",
                    LastName = "Küber",
                    StartDate = new DateTime(1975, 10, 19),
                    Rating = 6
                },
                new Person()
                {
                    FirstName = "Matias",
                    LastName = "Juarez",
                    StartDate = new DateTime(2000, 12, 2),
                    Rating = 8
                },
                new Person()
                {
                    FirstName = "Esteban",
                    LastName = "Alonzo",
                    StartDate = new DateTime(1997, 5, 19),
                    Rating = 7
                },
                new Person()
                {
                    FirstName = "Nicolas",
                    LastName = "Bello",
                    StartDate = new DateTime(1988, 2, 15),
                    Rating = 9
                },
                new Person()
                {
                    FirstName = "Federico",
                    LastName = "Vitale",
                    StartDate = new DateTime(1994, 1, 26),
                    Rating = 6
                },
                new Person()
                {
                    FirstName = "Juan",
                    LastName = "Perez",
                    StartDate = new DateTime(2015, 11, 1),
                    Rating = 5
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