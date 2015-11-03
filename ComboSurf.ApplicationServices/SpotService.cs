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
			var spotDto = new SpotDto {Id = id, Name = "Fairy Bower", WaveType = "Beach"};
			return spotDto;
		}
	}
}

//questions:
//I put the DTO in a Common folder - good idea? 