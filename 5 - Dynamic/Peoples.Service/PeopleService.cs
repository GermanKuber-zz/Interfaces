using System;
using System.Collections.Generic;
using Peoples.Repositories.Interface;

namespace Peoples.Service
{
    //TODO : 08 - Creo un servicio que coordine al repositorio y toda la lógica
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _repository;

        public PeopleService(IPeopleRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Person> GetPeople()
        {
            //TODO : 13 - Realizo test de la lógica
            var result = _repository.GetPeople();
            if (result != null)
                foreach (var person in result)
                {
                    if (person.StartDate.Year % 2 != 0)
                    {
                        person.Rating = person.Rating + 2;
                    }
                }

            return result;
        }

        public Person GetPerson(string lastName)
        {
            return _repository.GetPerson(lastName);
        }

        public void AddPerson(Person newPerson)
        {
            _repository.AddPerson(newPerson);
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
