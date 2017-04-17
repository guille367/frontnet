using AngularProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace AngularProj.Controllers
{
    public class AsyncPruebaController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        public Persona GetPersona()
        {
            return new Persona { ID = 2, Nombre = "see" };
        }

        public HttpResponseMessage PostPersona(Persona p)
        {
            return Request.CreateResponse(HttpStatusCode.BadRequest, "Todo mal");
        }
    }
}