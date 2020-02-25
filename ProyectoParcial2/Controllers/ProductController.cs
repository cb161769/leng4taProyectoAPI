using ProyectoParcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoParcial2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Clientes
        ProductoAPIController record = new ProductoAPIController();
        public ActionResult Index()
        {
            return View(record.Get());

        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(producto item)
        {

            record.Agregar(item);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            return View(record.GetID(id));
        }
        [HttpPost]
        public ActionResult Edit(producto item)
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