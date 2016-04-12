using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ComboSurf.Api;
using ComboSurf.Api.Models;
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
