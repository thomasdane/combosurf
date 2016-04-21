using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects
{
	public class SpotDto
	{
		public Object _id { get; set; }
		public String name { get; set; }
		public List<Report> reports { get; set; }
	}
}
