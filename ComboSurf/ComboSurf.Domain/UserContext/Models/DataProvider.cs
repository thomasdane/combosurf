using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboSurf.Domain.Models
{

	public class DataProvider : IEntity
	{
		public string Name { get; private set; }
		public Guid Id { get; private set; }

		private DataProvider(string name)
		{
			Id = Guid.NewGuid();
			Name = name;
		}

		//factory method
		public static DataProvider Create(string name)
		{
			return new DataProvider(name);
		}
	}
}
