using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SolicitudBien
    {
        public virtual int Id { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual List<Item> ListItems { get; set; }

        public SolicitudBien()
        {
            this.ListItems = new List<Item>();
        }
    }
}