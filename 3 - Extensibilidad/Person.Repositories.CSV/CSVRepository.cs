using System;
using System.Collections.Generic;
using Peoples.Repositories.Interface;

namespace Peoples.Repositories.CSV
{
    //TODO : 03 - Impelmento repositorio que lee un CSV
    public class CsvRepository : IPeopleRepository
    {
        //string path;

        //public CSVRepository()
        //{
        //    var filename = ConfigurationManager.AppSettings["CSVFileName"];
        //    path = AppDomain.CurrentDomain.BaseDirectory + filename;
        //}

        //public IEnumerable<Peoples.Data.Person> GetPeople()
        //{
        //    var people = new List<Peoples.Data.Person>();

        //    if (File.Exists(path))
        //    {
        //        var sr = new StreamReader(path);
        //        string line;
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            var elems = line.Split(',');
        //            var per = new Peoples.Data.Person()
        //            {
        //                FirstName = elems[0],
        //                LastName = elems[1],
        //                StartDate = DateTime.Parse(elems[2]),
        //                Rating = Int32.Parse(elems[3])
        //            };
        //            people.Add(per);
        //        }
        //    }
        //    return people;
        //}

        //public Peoples.Data.Person GetPerson(string lastName)
        //{
        //    Peoples.Data.Person selPerson = new Peoples.Data.Person();
        //    if (File.Exists(path))
        //    {
        //        var sr = new StreamReader(path);
        //        string line;
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            var elems = line.Split(',');
        //            if (elems[1].ToLower() == lastName.ToLower())
        //            {
        //                selPerson.FirstName = elems[0];
        //                selPerson.LastName = elems[1];
        //                selPerson.StartDate = DateTime.Parse(elems[2]);
        //                selPerson.Rating = Int32.Parse(elems[3]);
        //            }
        //        }
        //    }

        //    return selPerson;
        //}

        //public void AddPerson(Peoples.Data.Person newPerson)
        //{
        //    throw new NotImplementedException();
        //}

        //public void UpdatePerson(string lastName, Peoples.Data.Person updatedPerson)
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeletePerson(string lastName)
        //{
        //    throw new NotImplementedException();
        //}

        //public void UpdatePeople(IEnumerable<Peoples.Data.Person> updatedPeople)
        //{
        //    throw new NotImplementedException();
        //}
        public IEnumerable<Person> GetPeople()
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public void UpdatePeople(IEnumerable<Person> updatedPeople)
        {
            throw new NotImplementedException();
        }
    }

}
