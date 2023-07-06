using CoffeeShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace TestProject1
{
    public class OrderTests
    {
        [Fact]
        public void Order_Constructor_AssignsValuesCorrectly()
        {
            Order order1 = new Order();

            Assert.Empty(order1.Items);
        }

        [Fact]
        public void Order_AddItem_AddsItemtoItemList()
        {
            Item item1 = new Item("Coffee", 250);
            Item item2 = new Item("Bagel", 400);

            Order order1 = new Order();

            order1.AddItem(item1);
            order1.AddItem(item2);

            Assert.Equal(item1, order1.Items.First());
            Assert.Equal(item2, order1.Items.Last());
        }

        [Fact]
        public void Order_Total_CorrectlyAddsItemPrices()
        {
            Item item1 = new Item("Coffee", 250);
            Item item2 = new Item("Bagel", 400);

            Order order1 = new Order();

            order1.AddItem(item1);
            order1.AddItem(item2);

            var expectedTotal = 6.50;
            var actualTotal = order1.Total();

            Assert.Equal(expectedTotal, actualTotal);

        }
    }
}
