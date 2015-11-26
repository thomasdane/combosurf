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
			var response = await server.HttpClient.GetAsync("spots/1");
			Assert.Equal(HttpStatusCode.OK, response.StatusCode);
		}

        [Fact]
        public async Task GetMainRoute_ReturnsAllBreaks()
        {
            //Arrange
            var server = TestServer.Create<TestStartup>();
			var names = new List<String>();
			names.Add("Northern Beaches");
			names.Add("Eastern Beaches");
			names.Add("Batemans Bay");

            //Act
            var response = await server.HttpClient.GetAsync("spots");
            var result = await response.Content.ReadAsAsync<List<String>>();
            
            //Assert
			Assert.Equal(HttpStatusCode.OK, response.StatusCode);
			Assert.Equal(result, names);
        }

        [Fact]
        public async Task GetByName_ReturnsCorrectBreak()
        {
            //Arrange
            var server = TestServer.Create<TestStartup>();
            const string expectedBreak = "Manly";

            //Act
            var response = await server.HttpClient.GetAsync("spots/" + expectedBreak);
            var result = await response.Content.ReadAsAsync<string>();

            //Assert
            Assert.Equal(expectedBreak, result);
        }
        
        [Fact]
		public async Task CheckEndpointReturnsCorrectJson()
		{
			var server = TestServer.Create<TestStartup>();
			const int expectedId = 10000;
			var expectedSpot = new SpotDto { Id = expectedId, Name = "Manly"};

			var response = await server.HttpClient.GetAsync("spots/" + expectedId);
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

			var response = await server.HttpClient.GetAsync("spots/" + expectedId);

			Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
		}
	}

}
