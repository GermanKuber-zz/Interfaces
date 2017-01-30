using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using Peoples.Repositories.Interface;
using Xunit;

namespace Peoples.Service.Test
{
    public class PeopleServiceTest
    {
        [Fact]
        public void AddPerson_Test()
        {
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
                StartDate = new DateTime(2011, 1, 1)
            };
            IPeopleService service = new PeopleService(mockRepository);
            service.AddPerson(newPerson);


            var list = service.GetPeople();
            Assert.Equal(2, list.First().Rating);
        }
        //TODO : 04 - Install-Package Moq -Pre

        [Fact]
        public void GetPeople_Se_agrega_2_raiting_a_anio_inpar_con_mock()
        {

            //TODO : 04 - Implemento Mock para mockear mis servicios
            var contextPeople = new List<Person>();
            var newPerson = new Person
            {
                LastName = "LastName Test",
                StartDate = new DateTime(2011, 1, 1)
            };
            Mock<IPeopleRepository> mockPeopleRepository = new Mock<IPeopleRepository>();
            mockPeopleRepository.Setup(x => x.GetPeople()).Returns(contextPeople);
            mockPeopleRepository.Setup(x => x.AddPerson(newPerson)).Callback(() =>
            {
                contextPeople.Add(newPerson);
            });


            IPeopleService service = new PeopleService(mockPeopleRepository.Object);
            service.AddPerson(newPerson);


            var list = service.GetPeople();
            Assert.Equal(2, list.First().Rating);
        }

    }


}
