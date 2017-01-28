using Peoples.Data;
using System;
using System.Collections.Generic;

namespace Person.Repositories.Service
{
    //TODO : 02 -  Implemento un repositorio que consume data externa
    public class PeopleExternalRepository : IPeopleRepository
    {
        public void AddPerson(Peoples.Data.Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Peoples.Data.Person> GetPeople()
        {
            throw new NotImplementedException();
        }

        public Peoples.Data.Person GetPerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public void UpdatePeople(IEnumerable<Peoples.Data.Person> updatedPeople)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(string lastName, Peoples.Data.Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
