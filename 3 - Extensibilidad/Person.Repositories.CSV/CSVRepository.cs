//using Peoples.Data;
//using System;
//using System.Collections.Generic;

//namespace Person.Repositories.CSV
//{
//    //TODO : 03 - Impelmento repositorio que lee un CSV
//    public class CSVRepository : IPeopleRepository
//    {
//        string path;

//        public CSVRepository()
//        {
//            var filename = ConfigurationManager.AppSettings["CSVFileName"];
//            path = AppDomain.CurrentDomain.BaseDirectory + filename;
//        }

//        public IEnumerable<Peoples.Data.Person> GetPeople()
//        {
//            var people = new List<Peoples.Data.Person>();

//            if (File.Exists(path))
//            {
//                var sr = new StreamReader(path);
//                string line;
//                while ((line = sr.ReadLine()) != null)
//                {
//                    var elems = line.Split(',');
//                    var per = new Peoples.Data.Person()
//                    {
//                        FirstName = elems[0],
//                        LastName = elems[1],
//                        StartDate = DateTime.Parse(elems[2]),
//                        Rating = Int32.Parse(elems[3])
//                    };
//                    people.Add(per);
//                }
//            }
//            return people;
//        }

//        public Peoples.Data.Person GetPerson(string lastName)
//        {
//            Peoples.Data.Person selPerson = new Peoples.Data.Person();
//            if (File.Exists(path))
//            {
//                var sr = new StreamReader(path);
//                string line;
//                while ((line = sr.ReadLine()) != null)
//                {
//                    var elems = line.Split(',');
//                    if (elems[1].ToLower() == lastName.ToLower())
//                    {
//                        selPerson.FirstName = elems[0];
//                        selPerson.LastName = elems[1];
//                        selPerson.StartDate = DateTime.Parse(elems[2]);
//                        selPerson.Rating = Int32.Parse(elems[3]);
//                    }
//                }
//            }

//            return selPerson;
//        }

//        public void AddPerson(Peoples.Data.Person newPerson)
//        {
//            throw new NotImplementedException();
//        }

//        public void UpdatePerson(string lastName, Peoples.Data.Person updatedPerson)
//        {
//            throw new NotImplementedException();
//        }

//        public void DeletePerson(string lastName)
//        {
//            throw new NotImplementedException();
//        }

//        public void UpdatePeople(IEnumerable<Peoples.Data.Person> updatedPeople)
//        {
//            throw new NotImplementedException();
//        }
//    }

//}
