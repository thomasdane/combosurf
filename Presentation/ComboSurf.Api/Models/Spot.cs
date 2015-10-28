using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Web;

namespace ComboSurf.Api.Models
{
    public class SpotDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WaveType { get; set; }

		//only need factory methord these for domain obejcts
    }
}