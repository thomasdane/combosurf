using System;
using System.Collections.Generic;

namespace DataTransferObjects
{
	public class SpotDto
	{
		public Object _id { get; set; }
		public String name { get; set; }
		public List<Report> reports { get; set; }
	}
}
