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
		public async Task EndpointReturnsOk()
		{
			var server = TestServer.Create<TestStartup>();
			var response = await server.HttpClient.GetAsync("spot/1");
			Assert.Equal(HttpStatusCode.OK, response.StatusCode);
		}

		[Fact]
		public async Task CheckEndpointReturnsCorrectJson()
		{
			var server = TestServer.Create<TestStartup>();
			const int expectedId = 10000;
			var expectedSpot = new SpotDto { Id = expectedId, Name = "Manly"};

			var response = await server.HttpClient.GetAsync("spot/" + expectedId);
			var spot = await response.Content.ReadAsAsync<SpotDto>();

			Assert.Equal(HttpStatusCode.OK, response.StatusCode);
			Assert.Equal(expectedSpot.Id, spot.Id);
			Assert.Equal(expectedSpot.Name, spot.Name);
		}

		[Fact]
		public async Task CheckEndpointReturns404()
		{
			var server = TestServer.Create<TestStartup>();
			const int expectedId = -10;

			//get http response
			var response = await server.HttpClient.GetAsync("spot/" + expectedId);

			Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
		}
	}

}
