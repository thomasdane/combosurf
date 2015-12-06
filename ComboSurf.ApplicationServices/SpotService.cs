using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComboSurf.Domain.Services;
using DataTransferObjects;
using ComboSurf.Domain.Repositories;
using ComboSurf.Infrastructure;

namespace ComboSurf.ApplicationServices
{
	public class SpotService : ISpotService
	{
        private readonly ISpotRepository _spotRepository;

        public SpotService(ISpotRepository spotRepository)
        {
            _spotRepository = spotRepository;
        }

		public SpotDto GetByName(string name)
		{
            //var spotDto = CreateDummySpotDto(1, "Northern Beaches");
            //return spotDto; 
            var spot = _spotRepository.GetByName("manly");
            return spot;
		}

		public SpotDto GetById(int id)
		{
			var spotDto = CreateDummySpotDto(1, "Northern Beaches");
							return spotDto;
		}

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
	            CreateDummySpotDto(1,"Northern Beaches"),
	            CreateDummySpotDto(2, "Eastern Beaches"), 
				CreateDummySpotDto(3, "Batemans Bay")
            };
        }      
	}
}
