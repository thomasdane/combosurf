using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboSurf.Domain.Models
{
	public class BeachReport
	{

		public Array SwellDirection { get; set; }
		public Array SwellHeight { get; set; }
		public Array SwellPeriod { get; set; }
		public Array WindSpeed { get; set; }
		public Array WindDirection { get; set; }
		public Array Tide { get; set; }

	}
}
