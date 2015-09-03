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
        private IList<Spot> _spots;

        public SpotController()
        {
            _spots = new List<Spot>();
        }
        
        [Route("{id}")]
        [HttpGet]
        public Spot Get(int id)
        {
            var spot = AllSpots.Spots.FirstOrDefault(s => s.Id == id);
            return spot;
        }
        
        [Route("")]
        [HttpPost]
        public IHttpActionResult Add([FromBody]Spot spot)
        {
            AllSpots.Spots.Add(spot);
            return Created("spot", spot);
        }
    }

    public static class AllSpots
    {
        public static IList<Spot> Spots = new List<Spot>();
    }
}