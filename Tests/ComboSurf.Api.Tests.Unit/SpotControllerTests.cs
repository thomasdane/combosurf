using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using ComboSurf.Api.Controllers;
using ComboSurf.Domain.Services;
using DataTransferObjects;
using Newtonsoft.Json;
using NSubstitute;
using NSubstitute.Core.Arguments;
using Xunit;

namespace ComboSurf.Api.Tests.Unit
{
	public class SpotControllerTests
	{
		private readonly ISpotService _mockedSpotService = Substitute.For<ISpotService>();
		
		[Fact]
		public void ShouldCreateController()
		{
			_mockedSpotService.GetById(Arg.Any<int>()).ReturnsForAnyArgs(new SpotDto() {});

			var controller = new SpotController(_mockedSpotService);
			Assert.NotNull(controller);
		}

		[Fact]
		public void ShouldReturnSpotWhenPassedValidId()
		{
			_mockedSpotService.GetById(Arg.Any<int>()).ReturnsForAnyArgs(new SpotDto() { });
			var controller = new SpotController(_mockedSpotService);
			var result = controller.GetById(5);
			Assert.IsType<OkNegotiatedContentResult<SpotDto>>(result);
		}
	}


	//public class FakeSpotService : ISpotService
	//{

	//	public SpotDto GetById(int id)
	//	{
	//		return null;
	//	}
	//}
}
