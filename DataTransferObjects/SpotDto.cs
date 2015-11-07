using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects
{
	public class SpotDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string SwellHeight { get; set; }
		public string SwellDirection { get; set; }
		public string Period { get; set; }
		public string WindDirection { get; set; }
		public string WindSpeed { get; set; }
		public SwellnetDto SwellnetReport { get; set; }
		public CoastalwatchDto CoastalwatchReport { get; set; }
	}
}
