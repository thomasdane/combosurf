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
		public async Task Xxx()
		{
			var server = TestServer.Create<TestStartup>();
			var response = await server.HttpClient.GetAsync("spot");
			Assert.Equal(HttpStatusCode.OK, response.StatusCode);
		}
		
		//[Fact]
		//public void GetSpots()
		//{
		//	//Arrange
		//	var spot = new Spot { Id = 1, Name = "Manly", WaveType = "Beach Break"};
		//	var controller = new SpotController;

		//	//Act 
		//	var result = controller.Get(1);

		//	Assert.Same(product, result);
		//}
	}
}
