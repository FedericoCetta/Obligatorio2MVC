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

        //prueba


        // GET: Usuarios
        [HttpPost]
        public ActionResult Login(string EmailLogin, string PasswordLogin)
        {
            
            var buscado = db.Empleadoes.Where(e => e.Email == EmailLogin).Where(e => e.Password == PasswordLogin).Select(e => e.Email);

            if (buscado.Contains(EmailLogin))
            {

                return RedirectToAction("Index", "Empleados");
            }
            var buscado2 = db.Clientes.Where(e => e.Email == EmailLogin).Where(e => e.Password == PasswordLogin).Select(e => e.Email);
            // Otra sintaxis var buscado2 = from e in db.Clientes where e.Email == Email where e.Password == Password select e;
            if (buscado2.Contains(EmailLogin))
            {

                return RedirectToAction("Index", "Clientes");
            }
            

                return RedirectToAction("Index", "Home");
        }
        
    

      


    }
}