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
    public class CLientesController : ApiController
    {
        private BD_LENG4TA_2DOPARCIALEntities db = new BD_LENG4TA_2DOPARCIALEntities();

        // GET: api/CLientes
        public IQueryable<CLiente> GetCLientes()
        {
            return db.CLientes;
        }

        // GET: api/CLientes/5
        [ResponseType(typeof(CLiente))]
        public IHttpActionResult GetCLiente(int id)
        {
            CLiente cLiente = db.CLientes.Find(id);
            if (cLiente == null)
            {
                return NotFound();
            }

            return Ok(cLiente);
        }

        // PUT: api/CLientes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCLiente(int id, CLiente cLiente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cLiente.cli_ID)
            {
                return BadRequest();
            }

            db.Entry(cLiente).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CLienteExists(id))
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

        // POST: api/CLientes
        [ResponseType(typeof(CLiente))]
        public IHttpActionResult PostCLiente(CLiente cLiente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CLientes.Add(cLiente);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cLiente.cli_ID }, cLiente);
        }

        // DELETE: api/CLientes/5
        [ResponseType(typeof(CLiente))]
        public IHttpActionResult DeleteCLiente(int id)
        {
            CLiente cLiente = db.CLientes.Find(id);
            if (cLiente == null)
            {
                return NotFound();
            }

            db.CLientes.Remove(cLiente);
            db.SaveChanges();

            return Ok(cLiente);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CLienteExists(int id)
        {
            return db.CLientes.Count(e => e.cli_ID == id) > 0;
        }
    }
}