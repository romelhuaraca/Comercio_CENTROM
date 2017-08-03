using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CENTROM.Controllers
{
    public class HomeController : Controller
    {
        private Models.TiendaEntities bd = new Models.TiendaEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cursos( String id="")
        {
            //acceso a la base de datos
            var cursos = bd.Curso.Where(x => x.Denominacion.Contains(id))
                .Take(9)
                .ToList();
            ViewBag.palabra = id;
            return View(cursos);
        }

        public ActionResult Eventos()
        {
            return View();
        }

        public ActionResult Carrito()
        {
            return View();
        }

        public ActionResult Nosotros()
        {
            return View();
        }

        public ActionResult Contacto()
        {
            return View();
        }

    }
}