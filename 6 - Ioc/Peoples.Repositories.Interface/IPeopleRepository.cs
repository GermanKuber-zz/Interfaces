using System.Collections.Generic;

namespace Peoples.Repositories.Interface
{
    public interface IPeopleRepository
    {
        IEnumerable<Person> GetPeople();
        Person GetPerson(string lastName);
        void AddPerson(Person newPerson);
        void UpdatePerson(string lastName, Person updatedPerson);
        void DeletePerson(string lastName);
        void UpdatePeople(IEnumerable<Person> updatedPeople);
    }
}