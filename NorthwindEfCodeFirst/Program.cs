using Microsoft.EntityFrameworkCore;
using NorthwindEfCodeFirst.Contexts;
using NorthwindEfCodeFirst.Entities;

namespace NorthwindEfCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();

            //AddMethod();

            //AddCustomerOrder();

            //RemoveOrder();

            //UpdateMethod();

            //Linq();

            using (var northwindContext = new NorthwindContext())
            {
                var result = northwindContext.Customers.Where(c => c.CustomerID == "Yalim").Include("Orders");

                foreach (var customer in result)
                {
                    Console.WriteLine("{0},{1}", customer.CustomerID, customer.ContactName, customer.Orders.Count);

                }
            }


            Console.ReadLine();
        }

        private static void Linq()
        {
            using (var northwindContext = new NorthwindContext())
            {
                var result = northwindContext.Customers.Where(c => c.City == "London" || c.Country == "UK").
                    OrderBy(c => c.ContactName).Select(cus => new { cus.CustomerID, cus.ContactName });

                foreach (var order in result)
                {
                    Console.WriteLine("{0},{1}", customer.CustomerID, customer.ContactName);
                }
            }
        }

        private static void UpdateMethod()
        {
            using (var northwindContext = new NorthwindContext())
            {
                Order order = northwindContext.Orders.Find(1);

                order.ShipCity = "Ankara";

                northwindContext.SaveChanges();

            }
        }

        private static void RemoveOrder()
        {
            using (var northwindContext = new NorthwindContext())
            {
                Order order = northwindContext.Orders.Find(1);

                northwindContext.Orders.Remove(order);

                northwindContext.SaveChanges();

            }
        }

        private static void AddCustomerOrder()
        {
            using (var northwindContext = new NorthwindContext())

            {
                customer customer = northwindContext.Customers.Find("Yalim");
                customer.Orders.Add(new Order
                {
                    OrderID = 1,
                    OrderDate = DateTime.Now,
                    ShipCity = "İstanbul",
                    ShipCountry = "Türkiye"
                });
                northwindContext.SaveChanges();
            }
        }

        private static void AddMethod()
        {
            using (var northwindContext = new NorthwindContext())
            {
                var customer = new customer
                {
                    CustomerID = "Yalim",
                    CompanyName = "Gürbüz",
                    ContactName = "Gürbüz Yalım",
                    City = "İstanbul",
                    Country = "Türkiye"
                };

                northwindContext.Customers.Add(customer);
                northwindContext.SaveChanges();

            }
        }

        private static void One()
        {
            using (var northwindContext = new NorthwindContext())
            {
                foreach (var customer in northwindContext.Customers)
                {
                    Console.WriteLine($"{customer.CustomerID} {customer.CompanyName}");
                }
            }
        }
    }
}