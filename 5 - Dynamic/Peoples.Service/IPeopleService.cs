using System.Collections.Generic;
using Peoples.Repositories.Interface;

namespace Peoples.Service
{
    public interface IPeopleService
    {
        void AddPerson(Person newPerson);
        void DeletePerson(string lastName);
        IEnumerable<Person> GetPeople();
        Person GetPerson(string lastName);
        void UpdatePeople(IEnumerable<Person> updatedPeople);
        void UpdatePerson(string lastName, Person updatedPerson);
    }
}