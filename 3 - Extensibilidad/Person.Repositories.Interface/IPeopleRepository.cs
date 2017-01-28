using System.Collections.Generic;

namespace Peoples.Data
{
    //TODO : 01 - Modifico la interface de Repositorio para que trabaje con IENumerables
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