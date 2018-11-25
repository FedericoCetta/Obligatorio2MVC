using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionProductosMVC.Models
{
    public class ProductoImportado:Producto
    {
        public string PaisOrigen { get; set; }
        public int CantMinimaAPedir { get; set; }
       
        
    }
}
