using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComboSurf.Domain.Models;

namespace ComboSurf.Domain.Repositories
{
	public interface IReportRepository
	{
		Report GetByBeachProvider(int beachId, int dataProviderId);
	}
}
