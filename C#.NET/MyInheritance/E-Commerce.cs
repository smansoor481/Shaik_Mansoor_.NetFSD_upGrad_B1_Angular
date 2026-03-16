using System;
using System.Collections.Generic;

namespace MyInheritance
{
    internal class E_Commerce
    {
        static void Main()
        {
            List<Order> orders = new List<Order>();
            orders.Add(new StandardOrder { OrderId = 1, OrderAmount = 500 });
            orders.Add(new ExpressOrder { OrderId = 2, OrderAmount = 1000 });
            orders.Add(new InternationalOrder { OrderId = 3, OrderAmount = 2000 });

            foreach (Order order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }

    public class Order
    {
        public int OrderId;
        public int OrderAmount;

        public virtual int CalculateShippingCost()
        {
            return 50;
        }

        public override string ToString()
        {
            return $"OrderId: {OrderId}, OrderAmount: {OrderAmount}, Shipping Cost: {CalculateShippingCost()}";
        }
    }

    public class StandardOrder : Order
    {
        public override int CalculateShippingCost()
        {
            return 50;
        }
    }

    public class ExpressOrder : Order
    {
        public override int CalculateShippingCost()
        {
            return 100;
        }
    }

    public class InternationalOrder : Order
    {
        public override int CalculateShippingCost()
        {
            return 500;
        }
    }
}