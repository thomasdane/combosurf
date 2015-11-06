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
    [RoutePrefix("spot")]
    public class SpotController : ApiController
    {  
		//[Route("")]
		//[HttpGet]
		//public IHttpActionResult Get()
		//{
		//	return Ok();
		//}
	    private readonly ISpotService _spotService;

	    public SpotController(ISpotService spotService)
	    {
		    _spotService = spotService;
	    }

		[Route("{id}")]
		[HttpGet]
		public IHttpActionResult GetById(int id)
		{
			var spot = _spotService.GetById(id);

			return spot == null 
				? (IHttpActionResult) NotFound()
				: Ok(spot);
		}
    }
	//write unit tests controller and service
	//mock service
	//fakes vs mocks
	//two ways to di - constructor and methods. methods not great for controller. 
	//try to unit test the service
	//
}