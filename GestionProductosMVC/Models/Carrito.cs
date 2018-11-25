using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionProductosMVC.Models
{
    public class Carrito
    {
        [Key]
        public Usuario idCliente { get; set; }
        [Required]
        public Producto idProducto { get; set; }
        [Required]
        public int cantidad { get; set; }
        [Required]
        public int precio { get; set; }
        [Required]
        public DateTime fechaRegistro { get; set; }
    }
}