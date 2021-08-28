using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Product_Management.Database;
using Product_Management.Models;
using Product_Management.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;


namespace Product_Management.Repositories
{
    public class OrderRepositories : IOrderRepositories
    {
        PMDBContext _dbContext;
        public OrderRepositories()
        {
            _dbContext = new PMDBContext();
        }
        public bool AddOrder(Order order)
        {
            _dbContext.orders.Add(order);
            bool successCount = _dbContext.SaveChanges()>0;
            
            return successCount;
            
        }

        public bool DeleteOrder(int orderId)
        {
            var ord = _dbContext.orders.Where(p => p.Id == orderId).FirstOrDefault();
            _dbContext.orders.Remove(ord);
            bool successCount = _dbContext.SaveChanges()>0;
            //if (successCount > 0)
            //{
            //    var order = _dbContext.orders.Include(p => p.customer);
            //    return View("AllOrders", order);
            //}

            return successCount;
        }

        public ICollection<Order> GetAllOrders()
        {
            ICollection<Order> order = _dbContext.orders.Include(c=>c.customer).ToList();

            return order;
        }
    }
}
