using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Peoples.Core;
using Peoples.Repositories.Interface;
using Peoples.Repository.Memory;
using Peoples.Service;

namespace Peoples
{
    public class Program
    {
        public static IConfigurationRoot Configuration { get; set; }
        static void Main(string[] args)
        {
            SetConfigurationIoc();
            SetConfiguration();
            MenuManager.Start();
        }

        private static void SetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            ConfigurationWrapper.Configuration = builder.Build();
        }

        private static void SetConfigurationIoc()
        {
            //TODO : 02 - Configuro mi contenedor de IOC
            IocWrapper.ServiceProvider = new ServiceCollection()
           .AddSingleton<IPeopleService, PeopleService>()
           .AddSingleton<IPeopleRepository, PeopleRepositoryInMemory>()
           .BuildServiceProvider();
        }

    }
}
