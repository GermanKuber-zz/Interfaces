using System.IO;
using Microsoft.Extensions.Configuration;
using Peoples.Core;

namespace Peoples
{
    public class Program
    {
        public static IConfigurationRoot Configuration { get; set; }
        static void Main(string[] args)
        {
            SetConfiguration();
            //TODO : 01 - Modifico la implementacion de mi Main y utilizo el manager
            MenuManager.Start();
        }

        private static void SetConfiguration()
        {
            //TODO : 03 - Configuro el archivo de settings y lo guardo en una clase static
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            ConfigurationWrapper.Configuration = builder.Build();
        }
    }
}
