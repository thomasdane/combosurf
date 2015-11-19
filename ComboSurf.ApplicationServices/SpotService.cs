﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComboSurf.Domain.Services;
using DataTransferObjects;

namespace ComboSurf.ApplicationServices
{
	public class SpotService : ISpotService
	{
		private SpotDto CreateDummySpotDto(int id, string name)
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

			return new SpotDto
			{
				Id = id,
				Name = name,
				SwellnetReport = swellnetDto,
				CoastalwatchReport = coastalwatchDto,
				Period = "16 second",
				SwellDirection = "North Easterly",
				SwellHeight = "4-5ft",
				WindDirection = "Westerly",
				WindSpeed = "3 Knots"
			};
		}

		public IEnumerable<SpotDto> GetAll()
        {
            return new List<SpotDto>
            {
	            CreateDummySpotDto(1,"Manly"),
	            CreateDummySpotDto(2, "Bondi"), 
				CreateDummySpotDto(3, "Palm Beach")
            };
        }

        public string GetByName(string name)
        {
            string names = "Manly";
            return names;
        }
        
        public SpotDto GetById(int id)
		{
			if (id < 0) return null;

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
				Id = id, Name = "Manly", SwellnetReport = swellnetDto, CoastalwatchReport = coastalwatchDto, Period = "16 second", SwellDirection = "North Easterly", SwellHeight = "4-5ft", WindDirection = "Westerly", WindSpeed = "3 Knots"
			};
			return spotDto;
		}
	}
}
