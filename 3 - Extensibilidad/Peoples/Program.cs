using Peoples.Data;
using Person.Repositories.Service;
using System;
using System.Collections.Generic;

namespace Peoples
{
    public class Program
    {
        static readonly IPeopleRepository PeopleRepo = new PeopleExternalRepository();
        public static void Main(string[] args)
        {
            
          
            IEnumerable<Peoples.Data.Person> peoples = PeopleRepo.GetPeople();
            foreach (var person in peoples)
                WritePerson(person);

            Console.Read();
        }

        private static void WritePerson(Peoples.Data.Person data)
        {
            Console.WriteLine($"First Name : {data.FirstName} , Last Name :  {data.LastName}, Date : {data.StartDate}");
        }
    }
}
