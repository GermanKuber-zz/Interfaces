using System;
using System.Collections.Generic;
using Peoples.Repositories.Interface;

namespace Peoples
{
   
    public static class MenuManager
    {
        public static void Start()
        {
            ConsoleKeyInfo key;
            while (key.KeyChar != '4')
            {
                MenuManager.WriteMenu();
                key = Console.ReadKey();
                MenuManager.OptionMenu(key);
            }
            Console.Read();
        }

        public static void OptionMenu(ConsoleKeyInfo key)
        {
            if (key.KeyChar == '1')
                ShowResults(RepositoryTypeEnum.Memory);
            else if (key.KeyChar == '2')
                ShowResults(RepositoryTypeEnum.Service);
            else if (key.KeyChar == '3')
                ShowResults(RepositoryTypeEnum.Csv);
        }

        private static void ShowResults(RepositoryTypeEnum repositoryType)
        {
            IPeopleRepository repository = RepositoryFactory.GetRepository(repositoryType);
            IEnumerable<Person> peoples = repository.GetPeople();
            foreach (var person in peoples)
                WritePerson(person);
        }

        public static void WriteMenu()
        {
            Console.WriteLine($"Lista Personas");
            Console.WriteLine($"1 - LIsta personas en Memoria");
            Console.WriteLine($"2 - LIsta personas en Servicio");
            Console.WriteLine($"3 - LIsta personas en file");
            Console.WriteLine($"4 - Salir");
        }
        public static void WritePerson(Person data)
        {
            Console.WriteLine($"First Name : {data.FirstName} , Last Name :  {data.LastName}, Date : {data.StartDate}");
        }
    }
}