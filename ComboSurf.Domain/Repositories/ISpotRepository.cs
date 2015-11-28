using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComboSurf.Domain.UserContext.Models;

namespace ComboSurf.Domain.Repositories
{
	public interface ISpotRepository
	{
		Spot GetByName(string name);
	}
}
