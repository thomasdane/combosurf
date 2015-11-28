using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboSurf.Domain.UserContext.Models
{
	public class Spot
	{
		//field
		public string Name { get; private set; }

		//constructor
		private Spot(string name)
		{
			Name = name;
			
		}

		//factory method
		public static Spot Create(string name)
		{
			return new Spot(name);
		}
	}
}
