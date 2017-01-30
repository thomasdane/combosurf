using System.Collections.Generic;
using DataTransferObjects;

namespace ComboSurf.Domain.Services
{
	public interface ISpotService
	{
        IEnumerable<string> GetAll();
        SpotDto GetByName(string name);
	}
}
