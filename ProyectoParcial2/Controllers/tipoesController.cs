using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ProyectoParcial2.Models;

namespace ProyectoParcial2.Controllers
{
    public class tipoesController : ApiController
    {
        private BD_LENG4TA_2DOPARCIALEntities db = new BD_LENG4TA_2DOPARCIALEntities();

        // GET: api/tipoes
        public IQueryable<tipo> Gettipoes()
        {
            return db.tipoes;
        }

        // GET: api/tipoes/5
        [ResponseType(typeof(tipo))]
        public IHttpActionResult Gettipo(int id)
        {
            tipo tipo = db.tipoes.Find(id);
            if (tipo == null)
            {
                return NotFound();
            }

            return Ok(tipo);
        }

        // PUT: api/tipoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttipo(int id, tipo tipo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipo.tipoPRod_id)
            {
                return BadRequest();
            }

            db.Entry(tipo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tipoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/tipoes
        [ResponseType(typeof(tipo))]
        public IHttpActionResult Posttipo(tipo tipo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tipoes.Add(tipo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipo.tipoPRod_id }, tipo);
        }

        // DELETE: api/tipoes/5
        [ResponseType(typeof(tipo))]
        public IHttpActionResult Deletetipo(int id)
        {
            tipo tipo = db.tipoes.Find(id);
            if (tipo == null)
            {
                return NotFound();
            }

            db.tipoes.Remove(tipo);
            db.SaveChanges();

            return Ok(tipo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tipoExists(int id)
        {
            return db.tipoes.Count(e => e.tipoPRod_id == id) > 0;
        }
    }
}