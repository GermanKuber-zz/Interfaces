using System;
using System.Collections.Generic;
using Peoples.Repositories.Interface;
using Peoples.Service;
using Microsoft.Extensions.DependencyInjection;
namespace Peoples.Core
{
    public static class MenuManager
    {
        public static void Start()
        {

            //TODO : 03 - Utilizo mi contenedor para resolver mis dependencias.
            IPeopleService peopleService = IocWrapper.ServiceProvider.GetService<IPeopleService>();
            IEnumerable<Person> peoples = peopleService.GetPeople();
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