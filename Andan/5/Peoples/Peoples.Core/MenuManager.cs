using System;
using System.Collections.Generic;
using Peoples.Repositories.Interface;

namespace Peoples.Core
{
    public static class MenuManager
    {
        public static void Start()
        {
            
            //TODO : 02 - Obtengo el repositorio de mi factory pero sin depender de un parametro
            IPeopleRepository repository = RepositoryFactory.GetRepository();
            //TODO : 06 - Obtengo los resultados de diferentes repostiorios
            IEnumerable<Person> peoples = repository.GetPeople();

            //TODO : 09 - Utilizo el servicio en lugar del repositorio directo
                //IPeopleService peopleService = new PeopleService(repository);
                //IEnumerable<Person> peoples = peopleService.GetPeople();
            foreach (var person in peoples)
                WritePerson(person);
            Console.ReadKey();
        }
        public static void WritePerson(Person data)
        {
            Console.WriteLine($"First Name : {data.FirstName} , Last Name :  {data.LastName}, Date : {data.StartDate}");
        }
    }
}