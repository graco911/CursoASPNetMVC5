using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HolaMundo.Controllers
{
    public class HomeController : Controller
    {
        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var peliculas = Services.Pelicula.List();

            return View(peliculas);
        }

        public JsonResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            var persona = new Persona
            {
                Edad = 26,
                Nombre = "Carlos Alberto"
            };
            var persona2 = new Persona
            {
                Edad = 26,
                Nombre = "Carlos Alberto"
            };
            var persona3 = new Persona
            {
                Edad = 26,
                Nombre = "Carlos Alberto"
            };

            var personas = new List<Persona>()
            {
                persona, persona2, persona3
            };

            //return View();
            //regresar un content
            //return Content("<b>Prueba Carlos</b>");

            //Retornar un JSON
            return Json(personas, JsonRequestBehavior.AllowGet);

            //regresar una vista
            //return View();
        }
    }
}