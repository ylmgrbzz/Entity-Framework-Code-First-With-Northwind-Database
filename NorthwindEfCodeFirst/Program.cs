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


            Console.ReadLine();
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