using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;
using ComboSurf.Api.Models;
using ComboSurf.ApplicationServices;
using ComboSurf.Domain.Services;

namespace ComboSurf.Api.Controllers
{
    [RoutePrefix("spots")]
    public class SpotController : ApiController
    {  
	    private readonly ISpotService _spotService;

	    public SpotController(ISpotService spotService)
	    {
		    _spotService = spotService;
	    }

        [Route("")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var spots = _spotService.GetAll();
            List<String> names = new List<String>();
            foreach (DataTransferObjects.SpotDto spot in spots)
            {
                names.Add(spot.Name);
            }

            return names == null
                ? (IHttpActionResult)NotFound()
                : Ok(names);
        }

        [Route("{name:alpha}")]
        [HttpGet]
        public IHttpActionResult GetByName(string name)
        {
            var beach = _spotService.GetByName(name);

            return beach == null
                ? (IHttpActionResult)NotFound()
                : Ok(beach);
        }

		[Route("{id:int}")]
		[HttpGet]
		public IHttpActionResult GetById(int id)
		{
			var spot = _spotService.GetById(id);

			return spot == null 
				? (IHttpActionResult) NotFound()
				: Ok(spot);
		}
    }
	//to do:
    // fix testServer in every test
}