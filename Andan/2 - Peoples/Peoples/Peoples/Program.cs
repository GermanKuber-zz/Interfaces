using System;
using System.Collections.Generic;
using Peoples.Data;

namespace Peoples
{
    public class Program
    {
        static readonly IPeopleRepository PeopleRepo = new PeopleRepository();
        public static void Main(string[] args)
        {
            //TODO: 02 - Recorro la lista de People desde una lista
            //List<Person> peoples = PeopleRepo.GetPeople();

            //foreach (var person in peoples)
            //    WritePerson(person);

            //TODO: 03 - Recorro la lista de People desde un IEnumerable
            //IEnumerable<Person> peoples = PeopleRepo.GetPeople();
            //foreach (var person in peoples)
            //    WritePerson(person);

            Console.Read();
        }

        private static void WritePerson(Person data)
        {
            Console.WriteLine($"First Name : {data.FirstName} , Last Name :  {data.LastName}, Date : {data.StartDate}");
        }
    }
}
