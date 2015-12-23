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
		public SwellnetDto SwellnetReport { get; set; }
		public CoastalwatchDto CoastalwatchReport { get; set; }
	}
}
