using System;
using Peoples.Repositories.CSV;
using Peoples.Repositories.Interface;
using Peoples.Repositories.Service;
using Peoples.Repository.Memory;

namespace Peoples
{
    public static class RepositoryFactory
    {
        public static IPeopleRepository GetRepository()
        {
           return new CsvRepository();
        }
    }

    
}