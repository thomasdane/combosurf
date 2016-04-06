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
			return new SpotDto();
		}

		public IEnumerable<SpotDto> GetAll()
		{
			return new List<SpotDto>();
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