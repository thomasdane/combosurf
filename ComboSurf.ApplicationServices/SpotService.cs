using System.Collections.Generic;
using ComboSurf.Domain.Repositories;
using ComboSurf.Domain.Services;
using DataTransferObjects;

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
            var spot = _spotRepository.GetByName("manly");
            //business logic code here - average of reports
            return spot;
		}

		public SpotDto GetById(int id)
		{
			var spotDto = CreateDummySpotDto(1, "Northern Beaches");
							return spotDto;
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

			List<SwellnetDto> reports = new List<SwellnetDto> {swellnetDto}; 

            return new SpotDto
            {
                Name = name,
                Reports = reports
            };
        }
	}
}

/* NOTES:
 * core folder. this is like a framework for each project. core should be re-usable. 
 * entities have ids. value objects do not.
 * internal is only for project, public is for whole solution
 * entity/model is singular. because about an object/instance
 * contstructur ctor and tab
 * guid factory method vs new guid
 * factory method returns back a new object
*/