using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Assignments
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double Amount { get; set; }
    }
    internal class OrderCustomer
    {
        static void Main()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer { Id = 1, Name = "Mansoor" },
                new Customer { Id = 2, Name = "Rahul" },
                new Customer { Id = 3, Name = "Aisha" }
            };

            List<Order> orders = new List<Order>()
            {
                new Order { Id = 101, CustomerId = 1, Amount = 500 },
                new Order { Id = 102, CustomerId = 2, Amount = 1000 },
                new Order { Id = 103, CustomerId = 1, Amount = 700 },
                new Order { Id = 104, CustomerId = 3, Amount = 300 }
            };

            var res1 = from c in customers
                       join
                       o in orders
                       on c.Id equals o.CustomerId
                       select new
                       {
                           c.Name,
                           o.Amount
                       };

            foreach (var item in res1)
            {
                Console.WriteLine($"{item.Name} - {item.Amount}");
            }

            Console.WriteLine();

            var res2 = from c in customers
                      join o in orders
                      on c.Id equals o.CustomerId
                      group o by c.Name into g
                      select new
                      {
                          Name = g.Key,
                          TotalAmount = g.Sum(x => x.Amount)
                      };

            foreach (var item in res2)
            {
                Console.WriteLine($"{item.Name} - {item.TotalAmount}");
            }
        }
    }
}
