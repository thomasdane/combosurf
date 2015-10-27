using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Web;

namespace ComboSurf.Api.Models
{
    public class Spot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WaveType { get; set; }

	    private Spot(string name, string waveType)
	    {
		    Id = new int();
		    Name = name;
		    WaveType = waveType;
	    }

	    public static Spot Create(string name, string waveType)
	    {
		    return new Spot(name, waveType);
	    }
    }
}