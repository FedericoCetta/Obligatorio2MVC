using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GestionProductosMVC.Models
{
    public class MiContextoContext:DbContext
    {
   


        public MiContextoContext():base("con")
        {

        }



        public System.Data.Entity.DbSet<GestionProductosMVC.Models.Empleado> Empleadoes { get; set; }

        public System.Data.Entity.DbSet<GestionProductosMVC.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<GestionProductosMVC.Models.Usuario> Usuarios { get; set; }
    }
}