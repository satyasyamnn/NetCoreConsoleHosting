using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleApplicationHosting
{
    class Program
    {
        static async Task Main(string[] args)
        {   
            var host = new HostBuilder()
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddHostedService<FileWriterService>();
               });  
            await host.RunAsServiceAsync();
        }
    }
}
