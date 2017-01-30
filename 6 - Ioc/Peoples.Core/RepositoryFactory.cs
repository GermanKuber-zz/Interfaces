using System;
using Peoples.Repositories.Interface;

namespace Peoples.Core
{
    public static class RepositoryFactory
    {
        public static IPeopleRepository GetRepository()
        {
            var typeName = ConfigurationWrapper.Configuration["RepositoryType"];
            Type repoType = Type.GetType(typeName);
            object repoInstance = Activator.CreateInstance(repoType);
            IPeopleRepository repo = repoInstance as IPeopleRepository;
            return repo;
        }
    }
}