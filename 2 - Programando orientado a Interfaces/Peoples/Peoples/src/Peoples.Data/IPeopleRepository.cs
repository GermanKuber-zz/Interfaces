using System.Collections.Generic;

namespace Peoples.Data
{
    public interface IPeopleRepository
    {
        void AddPerson(Person newPerson);
        void DeletePerson(string lastName);
        List<Person> GetPeople();
        Person GetPerson(string lastName);
    }
}