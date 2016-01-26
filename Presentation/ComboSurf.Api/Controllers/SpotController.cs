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

	        return Ok(spots.Select(x => x.Name));
			//return all spots
			//add test for not found

			//create repo interface
			//create folder repo in infra
			//create repo classs implementing inferface
			//put the code in the repo from service
			//inject cool repository into service
			//so repo needs contrcsutot
			//constructor needas a param
			//param should be the interface the repository
			//repo should have getbyid and service should call it
			//repo should return a domain object
			//create domain model for spot
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
	//to do:
    // fix testServer in every test
}