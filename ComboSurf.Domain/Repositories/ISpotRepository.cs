using System.Collections.Generic;
using DataTransferObjects;

namespace ComboSurf.Domain.Repositories
{
	public interface ISpotRepository
	{
		SpotDto GetByName(string name);
		List<string> GetAll();
	}
}
