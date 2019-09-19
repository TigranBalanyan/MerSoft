using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreProject;
using StoreProject.Models;
using StoreProject.Repository;

namespace StoreProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        public IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository; //DI
        }


        [HttpGet]
        public IList<Product> GetAllProducts()
        {
            return productRepository.GetAllProducts();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {

            if (ModelState.IsValid)
            {
                productRepository.CreateProduct(product);
            }
            return Ok();
        }

        [HttpPut]
        public Task<IActionResult> Edit([Bind("No,Name,Colour")] Product product)
        {

            if (ModelState.IsValid)
            {
                productRepository.EditProduct(product);
            }
            return null;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Bind("No,Name,Colour")] Product product)
        {

            if (ModelState.IsValid)
            {
                if(productRepository.DeleteProduct(product) == null)
                {
                    return Ok();
                }
            }
            return BadRequest();
        }



        // GET: api/Products
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        //{
        //    return await _context.Products.ToListAsync();
        //}

        //// GET: api/Products/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Product>> GetProduct(int id)
        //{
        //    var product = await _context.Products.FindAsync(id);

        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    return product;
        //}

        // PUT: api/Products/5
        //    [HttpPut("{id}")]
        //    public async Task<IActionResult> PutProduct(int id, Product product)
        //    {
        //        if (id != product.Id)
        //        {
        //            return BadRequest();
        //        }

        //        _context.Entry(product).State = EntityState.Modified;

        //        try
        //        {
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ProductExists(id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return NoContent();
        //    }

        //    // POST: api/Products
        //    [HttpPost]
        //    public async Task<ActionResult<Product>> PostProduct(Product product)
        //    {
        //        _context.Products.Add(product);
        //        await _context.SaveChangesAsync();

        //        return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        //    }

        //    // DELETE: api/Products/5
        //    [HttpDelete("{id}")]
        //    public async Task<ActionResult<Product>> DeleteProduct(int id)
        //    {
        //        var product = await _context.Products.FindAsync(id);
        //        if (product == null)
        //        {
        //            return NotFound();
        //        }

        //        _context.Products.Remove(product);
        //        await _context.SaveChangesAsync();

        //        return product;
        //    }

        //    private bool ProductExists(int id)
        //    {
        //        return _context.Products.Any(e => e.Id == id);
        //    }
        //}
    }
}
