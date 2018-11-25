using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionProductosMVC.Models
{
    public class Pedido
    {
        public int pedidoId { get; set; }
        public Usuario idCliente { get; set; }
        public DateTime fecha { get; set; }
        public int totalPedido { get; set; }

    }
}