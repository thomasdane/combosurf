using System.Web.Http.Results;
using ComboSurf.Api.Controllers;
using ComboSurf.Domain.Services;
using NSubstitute;
using Xunit;
using DataTransferObjects;

namespace ComboSurf.Api.Tests.Unit
{
	public class SpotControllerTests
	{
		private readonly ISpotService _mockedSpotService = Substitute.For<ISpotService>();
		
		[Fact]
		public void ShouldCreateController()
		{
			_mockedSpotService.GetByName(Arg.Any<string>()).ReturnsForAnyArgs(new SpotDto() {});

			var controller = new SpotController(_mockedSpotService);
			Assert.NotNull(controller);
		}

		[Fact]
		public void ShouldReturnSpotWhenPassedValidId()
		{
			_mockedSpotService.GetByName(Arg.Any<string>()).ReturnsForAnyArgs(new SpotDto() { });
			var controller = new SpotController(_mockedSpotService);
			var result = controller.GetByName("easternbeaches");
			Assert.IsType<OkNegotiatedContentResult<SpotDto>>(result);
		}
	}
}
