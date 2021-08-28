using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Product_Management.Models;

namespace Product_Management.Repositories.Abstractions
{
    public interface IProductRepositories
    {
        bool AddProduct(Product product);
        ICollection<Product> GetAllProduct();
        bool DeleteProduct(int productId);

    }
}
