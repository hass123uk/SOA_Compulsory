using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using System_Integration_Compulsory.Models;

namespace System_Integration_Compulsory.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductsController : ApiController
    {
        private System_Integration_CompulsoryContext db = new System_Integration_CompulsoryContext();

        // GET: api/Products
        /// <summary>
        /// Get all products from the database.
        /// </summary>
        /// <returns>All Products</returns>
        public IQueryable<Product> GetProducts()
        {
            return db.Products;
        }

        // GET: api/Products/5
        /// <summary>
        /// Get a product from the database using the product id.
        /// </summary>
        /// <returns>A Product by ID</returns>
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(long id)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        /// <summary>
        /// Edit a product that is within the database using the product id.
        /// </summary>
        /// <returns>A Product by ID</returns>
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProduct(long id, Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.Id)
            {
                return BadRequest();
            }

            db.Entry(product).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        // POST: api/Products
        [ResponseType(typeof(Product))]
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Products.Add(product);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = product.Id }, product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(long id)
        {
            return db.Products.Count(e => e.Id == id) > 0;
        }
    }
}