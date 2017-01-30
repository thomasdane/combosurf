using System.Net;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Owin.Testing;

namespace ComboSurf.Api.Tests.Integration.Controllers
{
	public class SpotControllerTests
	{
		[Fact]
		public async Task CheckEndpointReturns404()
		{
			var server = TestServer.Create<TestStartup>();
			const int expectedId = -10;

			var response = await server.HttpClient.GetAsync("spots/" + expectedId);

			Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
		}
	}
}
