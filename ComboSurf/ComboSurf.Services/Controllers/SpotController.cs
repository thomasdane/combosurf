﻿using System;
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

        [Route("{id}")]
        [HttpDelete]
        public IHttpActionResult Delete([FromBody]Spot spot)
        {
            AllSpots.Spots.RemoveAt(spot.Id - 1);
            return Ok("spot deleted");
        }

        [Route("{id}")]
        [HttpPut]
        public IHttpActionResult Update([FromBody]Spot spot)
        {
            foreach (Spot s in AllSpots.Spots)
            {
                if (s.Id == spot.Id)
                {
                    s.Name = spot.Name;
                    s.WaveType = spot.WaveType;
                }
            }
            return Ok("Updated the " + spot.WaveType + spot.WaveType);
        }
    }

    public static class AllSpots
    {
        public static IList<Spot> Spots = new List<Spot>();
    }
}