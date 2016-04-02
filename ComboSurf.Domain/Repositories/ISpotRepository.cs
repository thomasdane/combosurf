using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComboSurf.Domain.UserContext.Models;
using DataTransferObjects;

namespace ComboSurf.Domain.Repositories
{
	public interface ISpotRepository
	{
		Task<SpotDto> GetByName(string name);
	}
}
