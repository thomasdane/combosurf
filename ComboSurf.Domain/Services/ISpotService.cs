﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObjects;

namespace ComboSurf.Domain.Services
{
	public interface ISpotService
	{
        IEnumerable<SpotDto> GetAll();
        SpotDto GetByName(string name);
	}
}
