using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
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
			catch (Exception)
			{
				return Content(HttpStatusCode.NotFound, "This spot does not yet exist");
			}
		}

        [Route("{name}")]
        [HttpPost]
        public IHttpActionResult AddReview([FromBody] Dictionary<string,int> review)
        {
            try
            {
                _spotService.AddReview(review);
                return Ok();
            }
            catch (Exception)
            {
                return Content(HttpStatusCode.NotFound, "This spot does not yet exist");
            }
        }
    }
}