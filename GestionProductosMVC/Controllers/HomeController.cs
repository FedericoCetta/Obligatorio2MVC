using GestionProductosMVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionProductosMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["Email"] == null)
            {
                return RedirectToAction("Login", "Usuarios");
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DatosYaCargados()
        {
            return View();
        }
     
        public ActionResult CargarProductos()
        {
            if (Session["Email"] == null)
            {
                return RedirectToAction("Login", "Usuarios");
            }


            MiContextoContext db = new MiContextoContext();


          

            bool CargarProductos = false;

            if (db.Productoes.Count() == 0)
            {
                CargarProductos = true;

                List<String> listaTemp = new List<String>();
                string ruta = AppDomain.CurrentDomain.BaseDirectory + "\\Archivo\\Productos.txt";
                StreamReader sr = new StreamReader(ruta);
                string linea = null;
                linea = sr.ReadLine();

                while ((linea != null))
                {
                    listaTemp.Add(linea);
                    linea = sr.ReadLine();
                }

                for (int i = 0; i < listaTemp.Count; i++)
                {
                    string cadena = listaTemp[i];
                    string[] vec1 = cadena.Split('|');
                    List<Producto> listaTramites = new List<Producto>();

                    if (vec1 != null)
                    {
                        Producto tramite = db.Productoes.Find(int.Parse(vec1[0]));
                        if (tramite == null)
                        {

                            Producto t = new Producto
                            {
                                //idProducto = int.Parse(vec1[0]), // no se si va
                                NombreProducto = vec1[1],
                                Descripcion = vec1[2],
                                Costo=int.Parse(vec1[3]),
                                PrecioVenta = int.Parse(vec1[4])
                       
                            };
                                db.Productoes.Add(t);
                            if (vec1[5] == "Importado") {
                                ProductoImportado pi = new ProductoImportado {
                                    PaisOrigen = vec1[6],
                                    CantMinimaAPedir = int.Parse(vec1[7])

                                };
                            }
                            if (vec1[5] == "Fabricado")
                            {
                                ProductoFabricado pf = new ProductoFabricado {
                                    TiempoPreviso = int.Parse(vec1[8])

                                };
                            }


                            db.SaveChanges();
                        }

                    }
                }
            }
            return View();
        }
     
    }
}