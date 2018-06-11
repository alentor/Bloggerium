using Bloggerium.Dal;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Bloggerium.Web2._1
{
    public class Program
    {
        public static void Main (string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder (string[] args)
        {
            SqlConfig.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bluggerium;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return WebHost.CreateDefaultBuilder(args).UseStartup <Startup>();
        }
    }
}