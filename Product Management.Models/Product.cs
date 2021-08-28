using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Management.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductNo { get; set; }
        public string Name  { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        
    }
}
