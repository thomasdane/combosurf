using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObjects;

namespace ComboSurf.Domain.Repositories
{
	public interface ISpotRepository
	{
		SpotDto GetByName(string name);
		List<string> GetAll();
	}
}
