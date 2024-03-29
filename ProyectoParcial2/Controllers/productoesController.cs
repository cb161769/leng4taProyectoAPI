﻿using System;
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
    public class productoesController : ApiController
    {
        private BD_LENG4TA_2DOPARCIALEntities db = new BD_LENG4TA_2DOPARCIALEntities();

        // GET: api/productoes
        public IQueryable<producto> Getproductoes()
        {
            return db.productoes;
        }

        // GET: api/productoes/5
        [ResponseType(typeof(producto))]
        public IHttpActionResult Getproducto(int id)
        {
            producto producto = db.productoes.Find(id);
            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }

        // PUT: api/productoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putproducto(int id, producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != producto.prod_id)
            {
                return BadRequest();
            }

            db.Entry(producto).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!productoExists(id))
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

        // POST: api/productoes
        [ResponseType(typeof(producto))]
        public IHttpActionResult Postproducto(producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.productoes.Add(producto);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = producto.prod_id }, producto);
        }

        // DELETE: api/productoes/5
        [ResponseType(typeof(producto))]
        public IHttpActionResult Deleteproducto(int id)
        {
            producto producto = db.productoes.Find(id);
            if (producto == null)
            {
                return NotFound();
            }

            db.productoes.Remove(producto);
            db.SaveChanges();

            return Ok(producto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool productoExists(int id)
        {
            return db.productoes.Count(e => e.prod_id == id) > 0;
        }
    }
}