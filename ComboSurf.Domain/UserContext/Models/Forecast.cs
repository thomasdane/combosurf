using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboSurf.Domain.Models
{

	public class Forecast
	
	{
		public Guid BeachId { get; private set; }
		public Guid DataProviderId { get; private set; }
		public int ForecastTime { get; private set; }
		public Array ForecastData { get; set; }

		private Forecast(Guid beachId, Guid dataProviderId, int forecastTime, Array forecastData)
		{
			BeachId = beachId;
			DataProviderId = dataProviderId;
			ForecastTime = forecastTime;
			ForecastData = forecastData;
		}

		//factory method
		public static Forecast Create(Guid beachId, Guid dataProviderId, int forecastTime, Array forecastData)
		{
			return new Forecast(beachId, dataProviderId, forecastTime, forecastData);
		}
	}
}
