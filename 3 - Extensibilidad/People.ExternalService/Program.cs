using Microsoft.AspNetCore.Hosting;
using People.ExternalService;
using System.IO;

class Program
{
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