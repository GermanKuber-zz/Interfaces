using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace People.ExternalService
{
    class Program
    {
        //TODO : 05 - Creo service rest
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();
            host.Run();
        }

    }
}