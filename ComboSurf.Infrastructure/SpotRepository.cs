using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComboSurf.Domain.Models;
using ComboSurf.Domain.Repositories;
using ComboSurf.Domain.UserContext.Models;
using DataTransferObjects;


namespace ComboSurf.Infrastructure
{
	class SpotRepository : ISpotRepository
	{
		public SpotDto GetByName(string name)
		{
			var swellnetDto = new SwellnetDto()
			{
				Content =
					"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
			};

			var coastalwatchDto = new CoastalwatchDto()
			{
				Content =
					"Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo."
			};

			var spotDto = new SpotDto
			{
				Id = 1,
				Name = name,
				SwellnetReport = swellnetDto,
				CoastalwatchReport = coastalwatchDto,
				Period = "16 second",
				SwellDirection = "North Easterly",
				SwellHeight = "4-5ft",
				WindDirection = "Westerly",
				WindSpeed = "3 Knots"
			};

			return spotDto;
		}
	}
}
				
