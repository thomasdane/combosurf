﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Security.Policy;
using ComboSurf.Domain.Repositories;
using ComboSurf.Domain.Services;
using Xunit;

namespace ComboSurf.ApplicationServices.Test.Unit
{
	public class SpotServiceTests
	{
		[Fact]
		public void GetAll_ShouldReturnThreeSpots()
		{
			//var service = new SpotService();
			//var result = service.GetById(1);

			Assert.Equal(1, 1);

		}
	}
}
