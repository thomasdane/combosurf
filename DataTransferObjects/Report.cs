using System;
using System.Collections.Generic;

namespace DataTransferObjects
{
	public class Report
	{
		public string name { get; set; }
		public string url { get; set; }
		public string swellHeight { get; set; }
		public string swellDirection { get; set; }
		public string period { get; set; }
		public string windDirection { get; set; }
		public string windSpeed { get; set; }
		public string sunrise { get; set; }
		public string sunset { get; set; }
		public string tide { get; set; }
		public string content { get; set; }
        public List<Reviews> reviews { get; set; }
        public DateTime date { get; set; }
	}
}

