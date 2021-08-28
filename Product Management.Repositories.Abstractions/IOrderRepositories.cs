using Product_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Management.Repositories.Abstractions
{
    public interface IOrderRepositories
    {
        bool AddOrder(Order order);
        bool DeleteOrder(int id);
        ICollection<Order> GetAllOrders();
    }
}
