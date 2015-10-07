using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboSurf.Domain.Models
{
	public class Report
	{
		public int BeachId { get; private set; }
		public int DataProviderId { get; private set; }
		public int ReportTime { get; private set; }
		public Array ReportData { get; set; }

		private Report(int beachId, int dataProviderId, int reportTime, Array reportData)
		{
			BeachId = beachId;
			DataProviderId = dataProviderId;
			ReportTime = reportTime;
			ReportData = reportData;
		}

		//factory method
		public static Report Create(int beachId, int dataProviderId, int reportTime, Array reportData)
		{
			return new Report(beachId, dataProviderId, reportTime, reportData);
		}
	}
}
