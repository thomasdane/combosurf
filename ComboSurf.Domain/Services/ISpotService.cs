using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboSurf.Domain.Services
{
	public interface ISpotService
	{
		SpotDto GetById(int id);
	}
	//usually upper layer cannot reference lower layers (in stack). opposite for onion. 

	//next week: create DTO project for spotDto
	//create service based on interface. spotservice implementing this interface. returning a hardcoded spot. 
	//controller call service by id, get return Dto. then controller makes decision based on return - if its null, return 404
}
