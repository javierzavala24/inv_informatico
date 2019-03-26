using Inv_Informatico.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inv_Informatico.WebAdmin.Controllers
{
     public class UbicacionesController : Controller
    {
        UbicacionBL _ubicacionBL;
        BodegasBL _bodegasBL;

        public UbicacionesController()
        {
            _ubicacionBL = new UbicacionBL();
            _bodegasBL = new BodegasBL();
        }

        // GET: Ubicaciones
        public ActionResult Index()
        {
            var listadeUbicaciones = _ubicacionBL.ObtenerUbicacion();

            return View(listadeUbicaciones);
        }

        public ActionResult Crear()
        {
            var nuevoUbicacion = new Ubicacion();
            var bodegas = _bodegasBL.ObtenerBodegas();


            ViewBag.BodegaId = 
                new SelectList(bodegas, "Id", "Descripcion");

            return View(nuevoUbicacion);
        }

        [HttpPost]
        public ActionResult Crear(Ubicacion ubicacion)
        {
          
                if (ubicacion.BodegaId == 0)
                {
                    ModelState.AddModelError("BodegaId", "Seleccione una categoria");
                    return View(ubicacion);

                _ubicacionBL.GuardarUbicacion(ubicacion);

                return RedirectToAction("Index");
            }

            var bodegas = _bodegasBL.ObtenerBodegas();

            ViewBag.BodegaId =
                new SelectList(bodegas, "Id", "Descripcion");

            return View(ubicacion);
        }

        public ActionResult Editar(int id)
        {
            var ubicacion = _ubicacionBL.ObtenerUbicacion(id);
            var bodegas = _bodegasBL.ObtenerBodegas();

            ViewBag.BodegaId =
                new SelectList(bodegas, "Id", "Descripcion", ubicacion.BodegaId);

            return View(ubicacion);
        }

        [HttpPost]
        public ActionResult Editar(Ubicacion ubicacion)
        {
            if (ModelState.IsValid)
            {
                if (ubicacion.BodegaId == 0)
                {
                    ModelState.AddModelError("BodegaId", "Seleccione una categoria");
                    return View(ubicacion);
                }

              

                _ubicacionBL.GuardarUbicacion(ubicacion);

                return RedirectToAction("Index");
            }

            var bodegas = _bodegasBL.ObtenerBodegas();

            ViewBag.BodegaId =
                new SelectList(bodegas, "Id", "Descripcion");

            return View(ubicacion);
        }

        public ActionResult Detalle(int id)
        {
            var ubicacion = _ubicacionBL.ObtenerUbicacion(id);

            return View(ubicacion);
        }

        public ActionResult Eliminar(int id)
        {
            var ubicacion = _ubicacionBL.ObtenerUbicacion(id);

            return View(ubicacion);
        }

        [HttpPost]
        public ActionResult Eliminar(Ubicacion ubicacion)
        {
            _ubicacionBL.EliminarUbicacion(ubicacion.Id);

            return RedirectToAction("Index");
        }

    }
}