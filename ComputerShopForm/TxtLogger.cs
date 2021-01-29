﻿using System;
using System.IO;

namespace ComputerShopForm
{
    internal class TxtLogger : Logger
    {
        public override void LogPurchase(ShoppingCart cart)
        {
            using (StreamWriter writer = new StreamWriter("log.txt", true))
            {
                writer.WriteLine($"---------------\nPurchase made at {DateTime.Now} for a total of € {cart.CalculatePrice()}:");
                foreach (IProduct product in cart.Shoppinglist)
                {
                    writer.WriteLine($"   {product.Name} - € {product.Price}");
                }
                writer.WriteLine("---------------");
            }
        }
    }
}