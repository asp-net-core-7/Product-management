using Microsoft.EntityFrameworkCore;
using Product_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_management.Database
{
    public class PMDBContext:DbContext
    {
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Customer> customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(local); Database=PMDB; Integrated Security=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
