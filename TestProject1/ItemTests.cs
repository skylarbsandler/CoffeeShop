using CoffeeShop;

namespace TestProject1
{
    public class ItemTests
    {
        [Fact]
        public void Item_IsCreatedwith_CorrectPropertyValues()
        {
            Item item1 = new Item("Coffee", 250);

            Assert.Equal("Coffee", item1.Name);
            Assert.Equal(250, item1.PriceInCents);
        }

        [Fact]
        public void Item_PriceInDollars_ReturnsCorrectPrice()
        {
            Item item1 = new Item("Coffee", 250);

            double cost = item1.PriceInDollars();

            Assert.Equal(2.50, cost);
        }
    }
}