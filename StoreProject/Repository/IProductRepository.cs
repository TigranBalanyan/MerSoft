using StoreProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Repository
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);
        void EditProduct(Product product);
        Task DeleteProduct(Product product);
        List<Product> GetAllProducts();
    }
}
