﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects
{
	public class Spot
	{
		public Object _id { get; set; }        
		public string Name { get; set; }
        public string SwellHeight { get; set; }
        public string SwellDirection { get; set; }
        public string Period { get; set; }
        public string WindDirection { get; set; }
        public string WindSpeed { get; set; }
        public string Content { get; set; }
	}
}

