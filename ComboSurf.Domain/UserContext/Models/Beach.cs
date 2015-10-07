using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboSurf.Domain.Models
{

	public class Beach : IEntity
	
	{
		public string Name { get; private set; }
		public string Region { get; private set; }
		public Guid Id { get; private set; }

		private Beach(string name, string region)
		{
			Id = Guid.NewGuid();
			Name = name;
			Region = region;
		}

		//factory method
		public static Beach Create(string name, string region)
		{
			return new Beach(name, region);
		}
	}
}
