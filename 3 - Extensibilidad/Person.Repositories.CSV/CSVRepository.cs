using System;
using System.Collections.Generic;
using Peoples.Repositories.Interface;

namespace Peoples.Repositories.CSV
{
    //TODO : 03 - Impelmento repositorio que lee un CSV (Implementacion dummy)
    public class CsvRepository : IPeopleRepository
    {
        
        public IEnumerable<Person> GetPeople()
        {
           return new List<Person>
           {
               new Person
               {
                   LastName = "Last name by CSV File",
                   FirstName = "Seba"
               }
           };
        }

        public Person GetPerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public void UpdatePeople(IEnumerable<Person> updatedPeople)
        {
            throw new NotImplementedException();
        }
    }

}
