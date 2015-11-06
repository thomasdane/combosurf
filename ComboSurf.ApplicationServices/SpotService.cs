using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComboSurf.Domain.Services;
using DataTransferObjects;

namespace ComboSurf.ApplicationServices
{
	public class SpotService : ISpotService
	{
		public SpotDto GetById(int id)
		{
			if (id < 0) return null;

			var spotDto = new SpotDto {Id = id, Name = "Fairy Bower", WaveType = "Beach"};
			return spotDto;
		}
	}
}
