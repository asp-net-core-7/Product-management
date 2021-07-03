using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Product_management.Database;
using Product_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_management.Controllers
{
    public class OrderController : Controller
    {
        PMDBContext _dbContext;
        public OrderController()
        {
             _dbContext = new PMDBContext();
        }
        public IActionResult Index()
        {
            var productList = _dbContext.products.Select(p => p);
            
            return View(productList);
        }
        public IActionResult Details(Order order)
        {
            _dbContext.orders.Add(order);
            int successCount = _dbContext.SaveChanges();
            if (successCount > 0)
            {
                //var prd = _dbContext.orders.Where(p => p.OrderNo == order.Id);
                return View(order);
            }
            else
            {
                return View();
            }
        }
        public IActionResult AllOrders()
        {
            var prd = _dbContext.orders.Select(p => p);
            return View(prd);
        }
        public IActionResult DeleteOrder(int id)
        {
            var ord = _dbContext.orders.Where(p => p.Id == id).FirstOrDefault();
            _dbContext.orders.Remove(ord);
            int successCount = _dbContext.SaveChanges();
            if (successCount > 0)
            {
                var order = _dbContext.orders.Select(p => p);
                return View("AllOrders", order);
            }

            return View(ord);
        }

    }
}
