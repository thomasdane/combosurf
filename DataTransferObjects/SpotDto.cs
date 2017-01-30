using System.Collections.Generic;

namespace DataTransferObjects
{
	public class SpotDto
	{
		public object _id { get; set; }
		public string name { get; set; }
		public List<Report> reports { get; set; }
	}
}
