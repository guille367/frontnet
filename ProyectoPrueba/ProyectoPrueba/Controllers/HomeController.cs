using ProyectoPrueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPrueba.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(devolverPeliculas());
        }

        // GET: Home/Details/5
        public async Task<ActionResult> Details(Pelicula p)
        {
            
            return View("Details",  FindMovieById(p));
        }

        private List<Pelicula> devolverPeliculas()
        {
            List<Pelicula> ll = new List<Pelicula>();
            ll = CrearListaPeliculas();
            return ll;
        }

        private List<Pelicula> CrearListaPeliculas()
        {
            List<Pelicula> lp = new List<Pelicula>();
            lp.Add(new Pelicula() { ID = 1, Descripcion = "Pelicula1" });
            lp.Add(new Pelicula() { ID = 2, Descripcion = "Pelicula2" });
            lp.Add(new Pelicula() { ID = 3, Descripcion = "Pelicula3" });
            return lp;
        }

        private Pelicula FindMovieById(Pelicula pe)
        {
            System.Threading.Thread.Sleep(2000);
            List<Pelicula> lp = CrearListaPeliculas();
            return lp.Find(pp => pp.ID == pe.ID);
        }

        private async Task<Pelicula> FindMovieByIdAsync(int id)
        {
            System.Threading.Thread.Sleep(2000);
            List<Pelicula> lp = CrearListaPeliculas();
            Pelicula p = new Pelicula();
            await Task.Run<Pelicula>(() => p = lp.Find(pp => pp.ID == id));
            ViewBag.p = p;
            System.IO.Directory.CreateDirectory("C:/Users/Ponce's/Desktop/Prueba");
            return p;
        }

        public ActionResult Buscar()
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult RenderPV()
        {
            try
            {
                List<Pelicula> lp = CrearListaPeliculas();
                return PartialView("_editPV", lp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View("_editPV");
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
