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


            UpdateMethod();

            Console.ReadLine();
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
                Customer customer = northwindContext.Customers.Find("Yalim");
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
                var customer = new Customer
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