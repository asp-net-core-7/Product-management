using Microsoft.AspNetCore.Mvc;
using Product_Management.Database;
using Product_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Product_Management.Repositories;
using Product_Management.Repositories.Abstractions;

namespace Product_Management.Controllers
{
    public class ProductController : Controller
    {
        public IProductRepositories _productRepositories;    
        public ProductController(IProductRepositories productRepositories)
        {
            _productRepositories = productRepositories;
        }
        public IActionResult Createproduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            bool successCount =_productRepositories.AddProduct(product);
            return Json(successCount);
        }
        public IActionResult GetAllProductJson()
        {
            ICollection<Product> products =  _productRepositories.GetAllProduct();
            return Json(products);
        }
        public IActionResult GetAllProduct()
        {
            ICollection<Product> products = _productRepositories.GetAllProduct();
            return View("Details",products);
        }

        public bool DeleteProduct(int id)
        {
            bool successCount = _productRepositories.DeleteProduct(id);
            return successCount;
        }
    }
}
