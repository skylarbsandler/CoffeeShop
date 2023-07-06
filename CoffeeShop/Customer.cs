using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Customer
    {
        public string Name;
        public List<Order> Orders;

        public  Customer(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public double TotalSpenct()
        {
            List<double> priceInCentsList = new List<double>();
            foreach (Order order in Orders)
            {
                foreach (Item item in order.Items)
                {
                    priceInCentsList.Add(item.PriceInCents);
                }
            }
            var sumDollars = priceInCentsList.Sum();
            return sumDollars / 100;
        }

        public void ItemsOrdered()
        {
            foreach (Order order in Orders)
            {
                foreach (Item item in order.Items)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
