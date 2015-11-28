using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComboSurf.Domain.Models;
using ComboSurf.Domain.Repositories;
using ComboSurf.Domain.UserContext.Models;


namespace ComboSurf.Infrastructure
{
	class SpotRepository : ISpotRepository
	{
		public Spot GetByName(string name)
		{
			string[] array = { "4ft", "East", "18s", "Gentle", "Offshore", "Rising Tide" };
			var report = Spot.Create("Manly");
			return report;
		}
	}
}
