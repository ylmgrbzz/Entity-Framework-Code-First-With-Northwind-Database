using Microsoft.EntityFrameworkCore;
using NorthwindEfCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEfCodeFirst.Contexts
{
    public class NorthwindContext : DbContext

    {
        //public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        //{
        //}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
