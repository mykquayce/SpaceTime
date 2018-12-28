using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace SpaceTime.Api.Tests
{
	public class HealthCheckTests
	{
		[Fact]
		public async Task HealthCheckTests_Get_ReturnsJson()
		{
			// Arrange, Act
			var (statusCode, _, body) = await Helpers.WebHelpers.GetAsync("/health");

			// Assert
			Assert.Equal(HttpStatusCode.OK, statusCode);
			Assert.Equal("Healthy", body);
		}
	}
}
