using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PeoplesNew.Core
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
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public int Rating { get; set; }
    }
    //TODO : 02 -  Implemento un repositorio que consume data externa
    public class PeopleExternalRepository : IPeopleRepository
    {
        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeople()
        {
            var result = GetPropleAsync().GetAwaiter();
            return result.GetResult();
        }

        private async Task<IEnumerable<Person>> GetPropleAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                
                    var data = await client.GetAsync("http://localhost:5000/api/People");
                    var jsonResponse = await data.Content.ReadAsStringAsync();
                    if (jsonResponse != null)
                        //return  JsonConvert.DeserializeObject<List<Person>>(jsonResponse);
                        return new List<Person>();
          
                }
            }

            catch (Exception exception)
            {
              
            }

           return new  List<Person>();
        }

        public Person GetPerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public void UpdatePeople(IEnumerable<Person> updatedPeople)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
