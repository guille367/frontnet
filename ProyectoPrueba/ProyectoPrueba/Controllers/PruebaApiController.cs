using ProyectoPrueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoPrueba.Controllers
{
    public class PruebaApiController : ApiController
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

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
        [HttpGet]
        public string Metodo()
        {
            var s = "asdasd";
            return s;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {

        }

        // POST api/<controller>
        public object LoQueSea(Actor actorsito)
        {
            return actorsito;
        }

        // POST api/<controller>
        public object LoQueSeaFromBody([FromBody]Actor actorsito)
        {
            return actorsito;
        }
    }
}