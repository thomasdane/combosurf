using System;
using System.Text;
using System.Collections.Generic;
using System.Security.Policy;
using Xunit;

namespace ComboSurf.ApplicationServices.Test.Unit
{
	public class SpotServiceTests
	{
		[Fact]
		public void test1()
		{
			var service = new SpotService();
			var result = service.GetById(1);

			Assert.Equal(1, result.Id);

		}
	}
}
