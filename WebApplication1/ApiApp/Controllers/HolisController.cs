using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiApp.Controllers
{
    public class HolisController : ApiController
    {
        [System.Web.Http.HttpGet]
        public HttpResponseMessage Prueba()
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, "esooo");
        }
    }
}