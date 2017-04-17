using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Item
    {
        public virtual int Id { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual int Cantidad { get; set; }
    }
}