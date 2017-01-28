using System;
using System.Collections.Generic;
using Peoples.Repositories.Interface;

namespace Peoples
{
    public static class MenuManager
    {
        public static void Start()
        {
            //TODO : 02 - Obtengo el repositorio de mi factory pero sin depender de un parametro
            IPeopleRepository repository = RepositoryFactory.GetRepository();
            IEnumerable<Person> peoples = repository.GetPeople();
            foreach (var person in peoples)
                WritePerson(person);
        }

  
        public static void WritePerson(Person data)
        {
            Console.WriteLine($"First Name : {data.FirstName} , Last Name :  {data.LastName}, Date : {data.StartDate}");
        }
    }
}