﻿using NUnit.Framework;
using System.Collections.Generic;

namespace ComputerShopForm.Test
{
    internal class ShoppingCartTest
    {
        public IProduct testproduct;
        public ShoppingCart testcart;
        public List<IProduct> testcart2;

        [SetUp]
        public void Setup()
        {
            testcart = ShoppingCart.GetShoppingCart();

            testproduct = new GamingPc("TestComputer", 1, "https://placekitten.com/200/300", "Test description", 1, 0, "TestMOBO", "TestHDD", "TestCPU", "TestPSU", "TestGPU", Performance.Affordable, true);
        }

        [Test]
        public void AddProductToCart_WhenPriceIsCalculated_PriceIsCorrect()
        {
            //ARRANGE
            testcart.AddProductToCart(testproduct);
            testcart.AddProductToCart(testproduct);
            testcart.AddProductToCart(testproduct);
            testcart.AddProductToCart(testproduct);

            //ACT
            double priceofcart = testcart.CalculatePrice();

            //ASSERT
            Assert.AreEqual(4.0, priceofcart);
        }

        [Test]
        public void RemoveProductFromCart_WhenCalled_IsRemovedFormCart()
        {
            //ARRANGE
            testcart.AddProductToCart(testproduct);
            testcart.AddProductToCart(testproduct);
            testcart.AddProductToCart(testproduct);
            testcart.AddProductToCart(testproduct);

            //ACT
            testcart.RemoveProductFromCart(testproduct.Name);

            //ASSERT
            Assert.AreEqual(testcart.Shoppinglist.Count, 3);
        }

        [Test]
        public void ClearCart_WhenCalled_ShoppinglistIsEmpty()
        {
            testcart.AddProductToCart(testproduct);
            testcart.AddProductToCart(testproduct);

            testcart.ClearCart();

            Assert.AreEqual(0, testcart.Shoppinglist.Count);
        }
    }
}