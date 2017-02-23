using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Peoples.Repositories.Interface;
using Newtonsoft.Json;

namespace Peoples.Repositories.Service
{
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
                        return JsonConvert.DeserializeObject<List<Person>>(jsonResponse);

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
