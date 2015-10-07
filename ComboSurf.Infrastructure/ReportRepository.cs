using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ComboSurf.Domain.Models;
using ComboSurf.Domain.Repositories;

namespace ComboSurf.Infrastructure
{
	class ReportRepository : IReportRepository
	{
		public Report GetByBeachProvider(int beachId, int dataProviderId)
		{
			string[] array = {"4ft", "East", "18s", "Gentle", "Offshore", "Rising Tide"};
			var report = Report.Create(1, 2, 3, array);
			return report;
		}
	}
}
