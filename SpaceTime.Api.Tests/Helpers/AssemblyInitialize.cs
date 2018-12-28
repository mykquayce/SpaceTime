using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;

namespace SpaceTime.Api.Tests.Helpers
{
	public class AssemblyInitialize : IDisposable
	{
		private static readonly TestServer _server;

		static AssemblyInitialize()
		{
			IWebHostBuilder builder = WebHost.CreateDefaultBuilder()
				.UseStartup<Startup>()
				.UseEnvironment(EnvironmentName.Development);

			_server = new TestServer(builder);
			Client = _server.CreateClient();
		}

		public static HttpMessageInvoker Client { get; }

		public void Dispose()
		{
			Client?.Dispose();
			_server?.Dispose();
		}
	}
}
