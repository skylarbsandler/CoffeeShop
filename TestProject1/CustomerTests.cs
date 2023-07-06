using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop;

namespace TestProject1
{
    public class CustomerTests
    {
        [Fact]
        public void Customer_Constructor_AssignsCorrectValues()
        {
            Customer customer1 = new Customer("Skylar");

            Assert.Equal("Skylar", customer1.Name);
            Assert.Empty(customer1.Orders);
        }

        [Fact]
        public void Customer_AddOrder_AddsOrdertoCustomerOrderList()
        {
            Customer customer1 = new Customer("Skylar");

            Item item1 = new Item("Latte", 375);
            Item item2 = new Item("Cappuccino", 400);
            Item item3 = new Item("Mocha", 450);
            Item item4 = new Item("Caramel Macchiato", 500);

            Order order1 = new Order();
            Order order2 = new Order();

            order1.AddItem(item1);
            order1.AddItem(item2);
            order2.AddItem(item3);
            order2.AddItem(item4);

            customer1.AddOrder(order1);
            customer1.AddOrder(order2);

            Assert.Equal(order1, customer1.Orders.First());
            Assert.Equal(order2, customer1.Orders.Last());

        }
    }
}
