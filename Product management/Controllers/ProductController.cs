using Microsoft.AspNetCore.Mvc;
using Product_management.Database;
using Product_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_management.Controllers
{
    public class ProductController : Controller
    {
        PMDBContext _dbContext;
        public ProductController()
        {
            _dbContext = new PMDBContext();
        }
        public IActionResult Createproduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _dbContext.products.Add(product);

            int successCount = _dbContext.SaveChanges();
            if (successCount > 0)
            {
                return RedirectToAction("Details");
            }
            else
            {
                return View();
            }
            
        }
        public IActionResult Details()
        {
            var product = _dbContext.products.Select(p => p);
            return View(product);
        }
        public IActionResult DeleteProduct(int id)
        {
            var prd = _dbContext.products.Where(p => p.Id==id).FirstOrDefault();
            _dbContext.products.Remove(prd);
            int successCount = _dbContext.SaveChanges();
            if(successCount>0)
            {
                var product = _dbContext.products.Select(p => p);
                return View("Details",product);
            }
            
            return View(prd);
        }
    }
}
