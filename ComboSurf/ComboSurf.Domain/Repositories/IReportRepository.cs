using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboSurf.Domain.Repositories
{
	class IReportRepository
	{
		private Task<BeachReport> GetAllReportsForBeach(int beachId);
	}
}
