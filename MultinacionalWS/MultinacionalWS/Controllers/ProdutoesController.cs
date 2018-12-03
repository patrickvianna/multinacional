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
using MultinacionalWS.Models;

namespace MultinacionalWS.Controllers
{
    public class ProdutoesController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/Produtoes
        public IQueryable<Produto> GetProdutoes()
        {
            return db.Produto;
        }

        // GET: api/Produtoes/5
        [ResponseType(typeof(Produto))]
        public IHttpActionResult GetProduto(int id)
        {
            Produto produto = db.Produto.Find(id);
            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }

        // PUT: api/Produtoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProduto(int id, Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != produto.id)
            {
                return BadRequest();
            }

            db.Entry(produto).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoExists(id))
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

        // POST: api/Produtoes
        [ResponseType(typeof(Produto))]
        public IHttpActionResult PostProduto(Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Produto.Add(produto);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = produto.id }, produto);
        }

        // DELETE: api/Produtoes/5
        [ResponseType(typeof(Produto))]
        public IHttpActionResult DeleteProduto(int id)
        {
            Produto produto = db.Produto.Find(id);
            if (produto == null)
            {
                return NotFound();
            }

            db.Produto.Remove(produto);
            db.SaveChanges();

            return Ok(produto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProdutoExists(int id)
        {
            return db.Produto.Count(e => e.id == id) > 0;
        }
    }
}