using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace SpaceTime.Api.Tests
{
	public class ValuesControllerTests
	{
		[Fact]
		public async Task ValuesControllerTests_Get_ReturnsJson()
		{
			// Arrange, Act
			var (statusCode, headers, json) = await Helpers.WebHelpers.GetAsync("/api/values");

			// Assert
			Assert.Equal(HttpStatusCode.OK, statusCode);
			Assert.False(string.IsNullOrWhiteSpace(json));
			Assert.StartsWith("[", json);
			Assert.Equal("[\"value1\",\"value2\"]", json);

			// Arrange
			var array = JsonConvert.DeserializeObject<string[]>(json);

			// Assert
			Assert.Equal(2, array.Length);
			Assert.Equal("value1", array[0]);
			Assert.Equal("value2", array[1]);
		}
	}
}
