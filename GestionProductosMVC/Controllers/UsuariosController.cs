using GestionProductosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionProductosMVC.Controllers
{
    public class UsuariosController : Controller
    {
        private MiContextoContext db = new MiContextoContext();

        [HttpGet]
        public ActionResult Login()
        {
           return View();
        }



        // GET: Usuarios
        [HttpPost]
        public ActionResult Login(string Email, string Password)
        {
            
            var buscado = db.Empleadoes.Where(e => e.Email == Email).Where(e => e.Password == Password).Select(e => e.Email);

            if (buscado.Contains(Email))
            {

                return RedirectToAction("Index", "Empleados");
            }
            var buscado2 = db.Clientes.Where(e => e.Email == Email).Where(e => e.Password == Password).Select(e => e.Email);
            // Otra sintaxis var buscado2 = from e in db.Clientes where e.Email == Email where e.Password == Password select e;
            if (buscado2.Contains(Email))
            {

                return RedirectToAction("Index", "Clientes");
            }
            

                return RedirectToAction("Index", "Home");
        }


    }
}