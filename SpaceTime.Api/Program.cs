using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SpaceTime.Api
{
	public class Program
	{
		public static Task Main(string[] args) => CreateWebHostBuilder(args).Build().RunAsync();

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>();
	}
}
