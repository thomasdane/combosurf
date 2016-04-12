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
            return _spotRepository.GetByName(name);
		}

		public IEnumerable<SpotDto> GetAll()
		{
			return new List<SpotDto>();
		}
	}
}