using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoParcial2.Models;

namespace ProyectoParcial2.Controllers
{
    public class TipoController : Controller
    {
        // GET: Tipo
        TipoAPIController record = new TipoAPIController();
        public ActionResult Index()
        {
            return View(record.Get());

        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tipo item)
        {

            record.Agregar(item);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            return View(record.GetID(id));
        }
        [HttpPost]
        public ActionResult Edit(tipo item)
        {
            record.Actualizar(item);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            return View(record.GetID(id));
        }
        [HttpPost]
        public ActionResult Delete(string id)
        {
            record.Eliminar(int.Parse(id));
            return RedirectToAction("Index");
        }
    }
}