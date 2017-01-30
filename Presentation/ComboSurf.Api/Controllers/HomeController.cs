using System.Web.Http;

namespace ComboSurf.Api.Controllers
{
	[Route("")]
    public class HomeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Index()
        {
            return Ok("Surf Forecast Aggregator");
        }
    }
}