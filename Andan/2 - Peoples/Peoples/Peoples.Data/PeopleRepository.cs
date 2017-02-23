using System;
using System.Collections.Generic;
using System.Linq;

namespace Peoples.Data
{
    //TODO: 01 - Creo un repositorio de Personas
    public class PeopleRepository : IPeopleRepository
    {
        private readonly List<Person> _context;

        public PeopleRepository()
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
        public List<Person> GetPeople()
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
            this._context.Add(newPerson);
        }
        public void DeletePerson(string lastName)
        {
            var itemDel = this._context.FirstOrDefault(x => x.LastName == lastName);
            if (itemDel != null)
                this._context.Remove(itemDel);
        }
    }
}