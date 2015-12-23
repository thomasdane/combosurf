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
	public class SpotRepository : ISpotRepository
	{	
		public SpotDto GetByName(string name)
		{
            var spotDto = CreateDummySpotDto("Eastern Beaches");
            return spotDto;
		}

		private SpotDto CreateDummySpotDto(string name)
		{
			var swellnetDto = new SwellnetDto()
			{
				Name = "Manly",
                SwellHeight = "1",
                SwellDirection = "NE",
                Period = "18s",
                WindDirection = "W", 
                WindSpeed = "3 Knots",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
			};

			var coastalwatchDto = new CoastalwatchDto()
			{
                Name = "Manly",
                SwellHeight = "1",
                SwellDirection = "NE",
                Period = "18s",
                WindDirection = "W",
                WindSpeed = "3 Knots",
                Content = "Still looks a bit average but decent 3ft now at S facing beaches. Morning Report: Waves 2ft +, Swell SE @ 7.7 sec, Winds SSE-SE-ESE 8-18 knots. Still looks a bit average but improvement on yesterday. Size around 2ft, maybe a little bigger S facing mostly from the SE."
			};

			return new SpotDto
			{
				Name = name,
				SwellnetReport = swellnetDto,
				CoastalwatchReport = coastalwatchDto,
			};
		}
	}
}
				
