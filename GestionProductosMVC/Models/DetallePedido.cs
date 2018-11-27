using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionProductosMVC.Models
{
    public class DetallePedido
    {
        // falta id pedido
        public Producto idProducto { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int cantidad { get; set; }

    }
}