using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPelicula.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "Esta es mi acción <b> predeterminada </b>...";
        //}

        //GET : /HelloWorld/Welcome/
        public ActionResult Welcome(string nombre, string apellido, int numVeces = 1)
        {
            ViewBag.Mensaje = "Hola " + nombre + " " + apellido + ", veces mostrado:";
            ViewBag.NumVeces = numVeces;
            return View();
        }

        //public string Welcome(string nombre, int ID = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hola " + nombre + ", ID: " + ID);
        //}
    }
}