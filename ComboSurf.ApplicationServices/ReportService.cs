using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComboSurf.Domain.Models;
using ComboSurf.Domain.Repositories;
using ComboSurf.Domain.Services;

namespace ComboSurf.ApplicationServices
{
	class ReportService : IReportService
	{
		private readonly IReportRepository _reportRepository;

		public Report Create(int beachId, int dataProviderId)
		{
			var report = _reportRepository.GetByBeachProvider(4, 5);
			return report;
		}
	}
}
