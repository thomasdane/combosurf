using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.UI.WebControls;
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

		[Route("{name}")]
		[HttpGet]
		public IHttpActionResult GetByName(string name)
		{
			try
			{
				var spot = _spotService.GetByName(name);
				return Ok(spot);
			}
			catch (Exception e)
			{
				return Content(HttpStatusCode.NotFound, "This spot does not yet exist");
			}
		}
	}
}