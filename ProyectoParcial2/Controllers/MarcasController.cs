using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoParcial2.Models;

namespace ProyectoParcial2.Controllers
{
    public class MarcasController : Controller
    {
        MarcAPIController record = new MarcAPIController();

        // GET: Marcas
        public ActionResult Index()
        {
            return View(record.Get());
        }

        // GET: Marcas/Details/5
      

        // GET: Marcas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Marcas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Marca item)
        {
            if (ModelState.IsValid)
            {
                record.Agregar(item);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        // GET: Marcas/Edit/5
        public ActionResult Edit(int id)
        {
            return View(record.GetID(id));
        }

        // POST: Marcas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Marca item)
        {
            record.Actualizar(item);
            return RedirectToAction("Index");
        }

        // GET: Marcas/Delete/5
        public ActionResult Delete(int id)
        {
            return View(record.GetID(id));
        }

        // POST: Marcas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            record.Eliminar(int.Parse(id));
            return RedirectToAction("Index");
        }

        
    }
}
