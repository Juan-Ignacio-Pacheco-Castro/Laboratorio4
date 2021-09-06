using Laboratorio4.Models;
using Laboratorio4.Handlers;
using System.Web.Mvc;
using System;

namespace Laboratorio4.Controllers
{
    public class PlanetasController : Controller
    {
        public ActionResult listadoDePlanetas()
        {
            PlanetasHandler accesoDatos = new PlanetasHandler();
            ViewBag.planetas = accesoDatos.obtenerTodosLosPlanetas();
            return View();
        }

        public ActionResult crearPlaneta()
        {
            return View();
        }
        [HttpPost]
        public ActionResult crearPlaneta(PlanetaModel planeta)
        {
            ViewBag.ExitoAlCrear = false;
            try
            {
                if (ModelState.IsValid)
                {
                    PlanetasHandler accesoDatos = new PlanetasHandler();
                    ViewBag.ExitoAlCrear = accesoDatos.crearPlaneta(planeta);
                    if (ViewBag.ExitoAlCrear)
                    {
                        ViewBag.Message = "El planeta " + planeta.nombre + " fue creado con éxito :)";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                ViewBag.Message = "Algo salió mal y no fue posible crear el planeta :(";
                return View();
            }
        }
    }
}