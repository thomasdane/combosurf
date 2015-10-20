using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ComboSurf.Api;


namespace ComboSurf.Api.Tests.Integration.Controllers
{
	class SpotControllerTests
	{
        [Fact]
        public void GetSpots()
        {
            //Arrange
            var spot = new Spot { Id = 1, Name = "Manly", WaveType = "Beach Break"};
            var controller = new SpotController;

            //Act 
            var result = controller.Get(1);

            Assert.Same(product, result);
        }
	}
}
