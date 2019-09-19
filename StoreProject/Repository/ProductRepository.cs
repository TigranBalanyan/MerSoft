using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreProject.Entities;
using StoreProject.Models;

namespace StoreProject.Repository
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(StoreContext context) : base(context)
        {
        }


        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            var productEntityList = _context.Products.ToList();
            foreach (var productEntity in productEntityList)
            {
                products.Add(new Product(productEntity.Id,productEntity.Name,productEntity.Group,productEntity.Price));
            }
            return products;
        }

        public void CreateProduct(Product product)
        {
            ProductEntity productEntity = new ProductEntity(product.Name, product.Price, product.Group);

            _context.Products.Add(productEntity); 
            
            _context.SaveChanges();
        }

        public Task DeleteProduct(Product product)
        {
            try
            {
                var productDeleted = _context.Products.Single((pr) => pr.Id == product.Id);
                _context.Products.Remove(productDeleted);
                return _context.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
        }

        public void EditProduct(Product product)
        {
            if(_context.Products.Where((pr)=>pr.Id == product.Id).Count() != 0)
            {
                _context.Products.Update(new ProductEntity(product.Id, product.Name, product.Price, product.Group));
            }
        }
    }
}
