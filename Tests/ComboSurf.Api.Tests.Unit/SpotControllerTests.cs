using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
