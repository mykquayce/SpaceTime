using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceTime.Api.Tests.Helpers
{
	public static class WebHelpers
	{
		public static async Task<(HttpStatusCode, HttpHeaders, string)> GetAsync(string url)
		{
			var request = new HttpRequestMessage(HttpMethod.Get, url);
			var response = await AssemblyInitialize.Client.SendAsync(request, CancellationToken.None);

			var statusCode = response.StatusCode;
			var headers = response.Headers;
			var body = await response.Content?.ReadAsStringAsync();

			return (statusCode, headers, body);
		}
	}
}
