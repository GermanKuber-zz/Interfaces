using System;
using Peoples.Repositories.Interface;

namespace Peoples.Core
{
    public static class RepositoryFactory
    {
        public static IPeopleRepository GetRepository()
        {
            //TODO : 04 - Obtengo la configuración de mi Repository desde el archivo de configuracion
            var typeName = ConfigurationWrapper.Configuration["RepositoryType"];
            //TODO : 05 - Genero una instancia con el tipo de mi configuracion
            Type repoType = Type.GetType(typeName);
            object repoInstance = Activator.CreateInstance(repoType);
            IPeopleRepository repo = repoInstance as IPeopleRepository;
            return repo;
        }
    }
}