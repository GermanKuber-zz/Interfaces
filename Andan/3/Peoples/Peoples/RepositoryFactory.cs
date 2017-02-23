using System;
using Peoples.Repositories.Interface;
using Peoples.Repositories.Service;
using Peoples.Repository.Memory;

namespace Peoples
{
    //TODO : 07 - Creo Factory de Repositorios
    public static class RepositoryFactory
    {
        public static IPeopleRepository GetRepository(RepositoryTypeEnum repositoryType)
        {
            IPeopleRepository repo = null;
            switch (repositoryType)
            {
                case  RepositoryTypeEnum.Service:
                    repo = new PeopleExternalRepository();
                    break;
                case RepositoryTypeEnum.Memory:
                    repo = new PeopleRepositoryInMemory();
                    break;
                default:
                    throw new ArgumentException("Invalid Repository Type");
            }
            return repo;
        }
    }

    public enum RepositoryTypeEnum
    {
        Service,
        Csv,
        Memory
    }
}