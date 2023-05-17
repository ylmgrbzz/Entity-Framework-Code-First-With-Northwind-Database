﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEfCodeFirst.Entities
{
    public class Order
    {
        public Customer()
        {
            Orders = new List<Order>();
        }
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public string OrderDate { get; set; }
        public List<Order> Orders { get; set; }



    }
}
