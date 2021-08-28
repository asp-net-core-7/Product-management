using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Management.Models
{
    public class CODetails
    {
        public List<Order> orders { get; set; }
        public List<Customer> customers { get; set; }
    }
}
