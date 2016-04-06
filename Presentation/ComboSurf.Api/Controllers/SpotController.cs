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
			if(spots == null) return NotFound();

	        return Ok(spots);
        }

        [Route("{name:alpha}")]
        [HttpGet]
        public IHttpActionResult GetByName(string name)
        {
            var spot = _spotService.GetByName(name);

            return spot == null
                ? (IHttpActionResult)NotFound()
                : Ok(spot);
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
}