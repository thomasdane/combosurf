using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ComboSurf.Services.Controllers
{
        [RoutePrefix("home")]
        public class HomeController : ApiController
        {
            [Route("waves")]
            [HttpGet]
            public IHttpActionResult Waves()
            {
                return Ok("Hello World");
            }
        }
}