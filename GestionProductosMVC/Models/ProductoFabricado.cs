using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionProductosMVC.Models
{
    public class ProductoFabricado:Producto
    {
        public int TiempoPreviso { get; set; }//El tiempo se registra en dias que va a demorar el producto
      //  public int idDelEmpleDelAlta { get; set; }// es el id del empleado que le dio de alta
       // public List<ProductoFabricado> productosFabricados { get; set; } = new List<ProductoFabricado>();

        

    

    }
}
