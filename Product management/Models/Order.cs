using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_management.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public DateTime Date { get; set; }
        public string OrderedBy { get; set; }
        public string Description { get; set; }
        public Customer Customer { get; set; }
    }
}
