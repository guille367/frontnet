using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PruebaApiController : ApiController
    {
        [System.Web.Http.HttpGet]
        public HttpResponseMessage Probandos()
        {
            
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, "esooo");
        }   
    }
}
