using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;
using ComboSurf.Services.Models;

namespace ComboSurf.Services.Controllers
{
    [RoutePrefix("spot")]
    public class SpotController : ApiController
    {
        [Route("")]
        [HttpGet]
        public Spot Get()
        {
            return new Spot
            {
                Id = 1,
                Name = "Fairy Bower",
                WaveType = "Point Break"
            };
        }
        [Route("")]
        [HttpPost]
        public IHttpActionResult Add([FromBody]Spot spot)
        {
            return Created("test", "test");
        }
    }
}