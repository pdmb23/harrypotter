using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HarryPotter
{
    [TestClass]
    public class HarryPotterUnitTest
    {
        private const string BookStone = "Stone";
        private const string BookChamber = "Chamber";
        private const string BookPrisoner = "Prisoner";
        private const string BookGoblet = "Goblet";
        private const string BookDeathly = "Deathly";

        [TestMethod]
        public void One_Book_Costs_8Dollars()
        {
            //ARRANGE
            Cart cart = new Cart();
            //ACT
            cart.AddToCart(BookGoblet);
            var result = cart.GetTotal();
            var price = 8;
            //ASSERT
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void Two_Same_Books_Cost_16Dollars()
        {
            var price = 16;
            Cart cart = new Cart();
            cart.AddToCart(BookGoblet);
            cart.AddToCart(BookGoblet);
            var result = cart.GetTotal();
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void Two_Different_Books_Have_5Percent_Discount()
        {
            var price = 15.2m;
            Cart cart = new Cart();
            cart.AddToCart(BookGoblet);
            cart.AddToCart(BookPrisoner);
            var result = cart.GetTotal();
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void Three_Different_Books_Has_10Percent_Discount()
        {
            //ARRANGE
            Cart cart = new Cart();

            //ACT
            cart.AddToCart(BookStone);
            cart.AddToCart(BookChamber);
            cart.AddToCart(BookPrisoner);
            var result = cart.GetTotal();
            
            //ASSERT
            var price = 21.6m;
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void Four_Different_Books_Has_20Percent_Discount()
        {
            //ARRANGE
            Cart cart = new Cart();

            //ACT
            cart.AddToCart(BookStone);
            cart.AddToCart(BookChamber);
            cart.AddToCart(BookPrisoner);
            cart.AddToCart(BookGoblet);
            var result = cart.GetTotal();

            //ASSERT
            var price = 25.6m;
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void Five_Different_Books_Has_25Percent_Discount()
        {
            //ARRANGE
            Cart cart = new Cart();

            //ACT
            cart.AddToCart(BookStone);
            cart.AddToCart(BookChamber);
            cart.AddToCart(BookPrisoner);
            cart.AddToCart(BookGoblet);
            cart.AddToCart(BookDeathly);
            var result = cart.GetTotal();

            //ASSERT
            var price = 30m;
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void Five_Books_With_Four_Different_Title_Has_20Percent_Discount()
        {
            Cart cart = new Cart();
            cart.AddToCart(BookStone);
            cart.AddToCart(BookChamber);
            cart.AddToCart(BookPrisoner);
            cart.AddToCart(BookGoblet);
            cart.AddToCart(BookGoblet);

            var result = cart.GetTotal();

            var price = 8 * 5 * 0.8m;

            Assert.AreEqual(price, result);

        }

        [TestMethod]
        public void No_Books_Must_Have_Zero_Total()
        {
            Cart cart = new Cart();
            var result = cart.GetTotal();
            var price = 0;
            Assert.AreEqual(price, result);
        }
    }
}
