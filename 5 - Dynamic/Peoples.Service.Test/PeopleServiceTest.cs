using System;
using System.Linq;
using Peoples.Repositories.Interface;
using Xunit;

namespace Peoples.Service.Test
{
    public class PeopleServiceTest
    {
        [Fact]
        public void AddPerson_Test()
        {
            //TODO : 12 - Realizo un test utilizando el repositorio mock
            var mockRepository = new MockPeopleRepository();
            var newPerson = new Person
            {
                LastName = "LastName Test"
            };
            IPeopleService service = new PeopleService(mockRepository);
            service.AddPerson(newPerson);


            var list = service.GetPeople();
            Assert.Equal(1, list.Count());
            Assert.Equal(newPerson.LastName, list.First().LastName);
        }

        [Fact]
        public void GetPeople_Se_agrega_2_raiting_a_anio_inpar()
        {
            
            var mockRepository = new MockPeopleRepository();
            var newPerson = new Person
            {
                LastName = "LastName Test",
                StartDate = new DateTime(2011,1,1)
            };
            IPeopleService service = new PeopleService(mockRepository);
            service.AddPerson(newPerson);


            var list = service.GetPeople();
            Assert.Equal(2, list.First().Rating);
        }
    }


}
