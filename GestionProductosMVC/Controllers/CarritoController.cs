using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GestionProductosMVC.Models;

namespace GestionProductosMVC.Controllers
{
    public class CarritoController : Controller
    {
        private MiContextoContext db = new MiContextoContext();

        // GET: Carrito
        public ActionResult Index()
        {
            return View();
        }

        // GET: Carrito/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Carrito orden = db.Carrito.Find(id);

            if (orden == null)
            {
                return HttpNotFound();
            }

            return View(orden);
        }


        // GET: Carrito/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Carrito/Create
        [HttpPost]
        public ActionResult Create(Carrito ordendeCompra)
        {
            if (ModelState.IsValid)
            {
                db.Carrito.Add(ordendeCompra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

             return View(ordendeCompra);
        
        }

        // GET: Carrito/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //busco el id pasado con el find en la base de datos

            Carrito orden = db.Carrito.Find(id);

            if (orden == null)
            {
                return HttpNotFound();
            }
            return View(orden);
        }

        // POST: Carrito/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Carrito orden)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orden).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orden);
        }

        // GET: Carrito/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //busco id con el find en la base de datos
            Carrito orden = db.Carrito.Find(id);

            if (orden == null)
            {
                return HttpNotFound();
            }
            return View(orden);
        }

        // POST: Carrito/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            Carrito orden = db.Carrito.Find(id);
            db.Carrito.Remove(orden);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
