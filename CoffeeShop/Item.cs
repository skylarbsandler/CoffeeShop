using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CoffeeShop;

namespace CoffeeShop
{
    public class Item
    {
        public string Name;
        public double PriceInCents;

        public Item(string name, double priceincents)
        {
            Name = name;
            PriceInCents = priceincents;
        }

        public double PriceInDollars()
        {
            return PriceInCents / 100;
        }
    }
}

