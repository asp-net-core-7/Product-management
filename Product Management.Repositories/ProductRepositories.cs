using Product_Management.Database;
using Product_Management.Models;
using Product_Management.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Management.Repositories
{
    public class ProductRepositories : IProductRepositories
    {
        PMDBContext _dbContext;
        public ProductRepositories()
        {
            _dbContext = new PMDBContext();
        }
        public bool AddProduct(Product product)
        {
            _dbContext.products.Add(product);
            bool successCount = _dbContext.SaveChanges()>0;
            return successCount;
        }

        public bool DeleteProduct(int productId)
        {
            var prd = _dbContext.products.Where(p => p.Id == productId).FirstOrDefault();
            _dbContext.products.Remove(prd);
            bool successCount = _dbContext.SaveChanges()>0;
            //if (successCount > 0)
            //{
            //    var product = _dbContext.products.Select(p => p);
            //    return View("Details", product);
            //}

            return successCount;
        }

        public ICollection<Product> GetAllProduct()
        {
            var product = _dbContext.products.ToList();
            return product;
        }
    }
}
