using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoPrueba.Models;
using System.Web.Mvc.Ajax;
using System.Net;

namespace ProyectoPrueba.Controllers
{
    public class BuscarController : Controller
    {
        // GET: Buscar
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Filtrar(Pelicula p, Actor a)
        {
            List<Pelicula> lp = CrearListaPeliculas();
            
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Y hace las cosas bien papá");
        }

        private List<Pelicula> CrearListaPeliculas()
        {
            List<Pelicula> lp = new List<Pelicula>();
            lp.Add(new Pelicula() { ID = 1, Descripcion = "Pelicula1" });
            lp.Add(new Pelicula() { ID = 2, Descripcion = "Pelicula2" });
            lp.Add(new Pelicula() { ID = 3, Descripcion = "Pelicula3" });
            return lp;
        }

    }
}