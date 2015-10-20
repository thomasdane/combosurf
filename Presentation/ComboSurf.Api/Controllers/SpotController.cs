using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;
using ComboSurf.Api.Models;

namespace ComboSurf.Api.Controllers
{
    [RoutePrefix("spot")]
    public class SpotController : ApiController
    {
        
        [Route("{id}")]
        [HttpGet]
        public Spot Get(int id)
        {
            
        }
        

}