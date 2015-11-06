using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComboSurf.Api.Controllers;
using ComboSurf.Domain.Services;
using DataTransferObjects;
using NSubstitute;
using NSubstitute.Core.Arguments;
using Xunit;

namespace ComboSurf.Api.Tests.Unit
{
	public class SpotControllerTests
	{
		[Fact]
		public void xxx()
		{
			var mockedSpotService = Substitute.For<ISpotService>();
			
			mockedSpotService.GetById(Arg.Any<int>()).ReturnsForAnyArgs(new SpotDto() {});


			var controller = new SpotController(mockedSpotService);
			Assert.NotNull(controller);
		}
	}


	public class FakeSpotService : ISpotService
	{

		public SpotDto GetById(int id)
		{
			return null;
		}
	}
}
