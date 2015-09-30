using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComboSurf.Domain.Services;
using ComboSurf.Domain.Repositories;

namespace ComboSurf.AppServices
{
    public class ReportService : IReportService
    {
		private readonly IReportRepository _reportRepository;
		private readonly IBeachRepository _beachRepository;
	    
		public ReportService(IReportRepository reportRepository, IMappingEngine mappingEngine)
		{
			_mappingEngine = mappingEngine;
		}
		public Task<Report> GetBeachReport(string beach, Reports reports)
	    {
		    return reportRepository.GetAllReportsForBeach(beach, reports);
	    }
    }
}
