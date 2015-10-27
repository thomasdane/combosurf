using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ComboSurf.Api;
using Microsoft.Owin.Testing;


namespace ComboSurf.Api.Tests.Integration.Controllers
{
	public class SpotControllerTests
	{

		[Fact]
		public async Task EndpointReturnsOk()
		{
			var server = TestServer.Create<TestStartup>();
			var response = await server.HttpClient.GetAsync("spot");
			Assert.Equal(HttpStatusCode.OK, response.StatusCode);
		}

		[Fact]
		public async Task CheckEndpointReturnsCorrectJson()
		{
			var server = TestServer.Create<TestStartup>();
			var response = await server.HttpClient.GetAsync("spot/1");
			var expectedJson = @"{""id"":0,""name"":""Fairy Bower"",""waveType"":""Beach""}";
			Assert.Equal(expectedJson, response.Content.ReadAsStringAsync().Result);
    
		}
	}
}
