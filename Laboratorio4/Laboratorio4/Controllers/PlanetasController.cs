using Laboratorio4.Models;
using Laboratorio4.Handlers;
using System.Web.Mvc;
using System;

namespace Laboratorio4.Controllers
{
    public class PlanetasController : Controller
    {
        // GET: Planetas
        public ActionResult listadoDePlanetas()
        {
            PlanetasHandler accesoDatos = new PlanetasHandler();
            ViewBag.planetas = accesoDatos.obtenerTodosLosPlanetas();
            return View();
        }
    }
}