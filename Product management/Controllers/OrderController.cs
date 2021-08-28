using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
    public class OrderController : Controller
    {
        public IOrderRepositories _orderRepositories { get; set; }
        public IProductRepositories _productRepositories { get; set; }
        public OrderController(IOrderRepositories orderRepositories,IProductRepositories productRepositories)
        {
            _orderRepositories = orderRepositories;
            _productRepositories = productRepositories;
        }
        public IActionResult Index()
        {
            ICollection<Product> productList = _productRepositories.GetAllProduct();

            return View(productList);
        }
        public bool AddOrder(Order order)
        {
            bool successCount = _orderRepositories.AddOrder(order);
            return successCount;
        }
        public IActionResult GetAllOrders()
        {
            ICollection<Order> orderList = _orderRepositories.GetAllOrders();
            return View(orderList);
        }
        public bool DeleteOrder(int id)
        {
            bool successCount = _orderRepositories.DeleteOrder(id);
            return successCount;
        }

    }
}
