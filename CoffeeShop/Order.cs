﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Order
    {
        public List<Item> Items;

        public Order()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        //public double Total()
        //{
        //    List<double> priceInCentsList = new List<double>();
        //    foreach (Item item in Items)
        //    {
        //        double sum =+ item.PriceInCents;
        //    }
        //    return sum;
        //}
    }
}
