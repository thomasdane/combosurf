using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ComboSurf.Services.Controllers
{
        [Route("")]
        public class HomeController : ApiController
        {
            [HttpGet]
            public IHttpActionResult Index()
            {
                return Ok("<h1>Hello World</h1>");
            }
        }
     
    
        //[RoutePrefix("home")]
        //public class HomeController : ApiController
        //{
        //    [Route("waves")]
        //    [HttpGet]
        //    public IHttpActionResult Waves()
        //    {
        //        return Ok("Wave info");
        //    }
        //}
}