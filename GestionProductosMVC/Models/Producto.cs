using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace GestionProductosMVC.Models
{
    public class Producto
        
    {
        //EL NOMBRE DEL PRODUCTO TIENE QUE SER UNICO. CONTROLAR.
        [Key]
        public int idProducto { get; set; }
        [Required]
        public string NombreProducto { get; set;}
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int Costo { get; set; }
        [Required]
        public int PrecioVenta { get; set; }
       // public string tipoProducto { get; set; }

     


    }



}
