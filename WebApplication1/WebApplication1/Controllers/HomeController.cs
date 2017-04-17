using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CrearListas();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Generar()
        {
            CrearListas();

            MergeLists();

            return View("Index");
        }

        private void MergeLists()
        {
            SolicitudBien sb = ViewBag.PrimerLista;
            SolicitudBien sb2 = ViewBag.SegundaLista;

            SolicitudBien sbMerge = null;

            var q = sb.ListItems.Where(i => sb2.ListItems.Contains(i));
            var w = sb.ListItems.Where(i => !sb2.ListItems.Contains(i));

            sb.ListItems[2].Cantidad = 99;
            sb.ListItems[3].Cantidad = 72;

            List<Item> ll = sb.ListItems.Join<Item,Item,long,Item>
                (sb2.ListItems, 
                 it1 => it1.Id,
                 it2 => it2.Id, 
                 ( it1, it2 ) => {
                     return it1;
                 }).ToList();

            ll.AddRange(sb2.ListItems.Where(x => !sb.ListItems.Exists( k => k.Id == x.Id )));

            List<Item> lq = sb.ListItems.Join<Item, Item, long, Item>
                (sb2.ListItems,
                 it1 => it1.Id,
                 it2 => it2.Id,
                 (it1, it2) => {
                     return it2;
                 }).ToList();

            lq.AddRange(sb2.ListItems.Where(x => !sb.ListItems.Contains(x)));

            sb.ListItems.GroupJoin<Item, Item, long, Item>(sb2.ListItems, i => i.Id, i => i.Id, (i,j) => { return i; });

            ViewBag.ListaMerge = sb.ListItems.Join<Item, Item, long, List<Item>>
                (sb2.ListItems,
                 it1 => it1.Id,
                 it2 => it2.Id,
                 (it1, it2) =>
                 {
                     List<Item> lti = new List<Item>();
                     if (it1.Id == it2.Id)
                     {
                         lti.Add(it2);
                     }
                     return lti;
                 }).ToList();
        }

        private void CrearListas()
        {
            SolicitudBien sb = new SolicitudBien();
            SolicitudBien sb2 = new SolicitudBien();

            sb.Descripcion = "Primera";
            sb2.Descripcion = "Segunda";

            for (int i = 0; i < 6; i++)
            {
                if (i < 4)
                {
                    Item t = new Item();
                    t.Descripcion = "Item#" + i.ToString();
                    t.Id = i;

                    t.Cantidad = i * 4;
                    sb.ListItems.Add(t);
                }

                if (i >= 2)
                {
                    Item t = new Item();
                    t.Descripcion = "Item#" + i.ToString();
                    t.Id = i;

                    t.Cantidad = i * 4;
                    sb2.ListItems.Add(t);
                }

            }

            ViewBag.PrimerLista = sb;
            ViewBag.SegundaLista = sb2;
        }

    }
}