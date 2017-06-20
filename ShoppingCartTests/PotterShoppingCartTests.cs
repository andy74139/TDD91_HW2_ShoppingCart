using System.Collections.Generic;
using NUnit.Framework;

namespace ShoppingCart.Tests
{
    [TestFixture]
    public class PotterShoppingCartTests
    {
        [TestCase(1, ExpectedResult = 100)]
        public int GetPriceForPotterITest(int amount)
        {
            var target = new PotterShoppingCart();
            return target.GetPriceForPotterI(amount);
        }

        [TestCase(1, 1, ExpectedResult = 190)]
        public int GetPriceForPotterOneTwoTest(int amount1, int amount2)
        {
            var target = new PotterShoppingCart();
            return target.GetPriceForPotterOneTwo(amount1, amount2);
        }

        [TestCase(new[] {1, 1, 1, 0}, ExpectedResult = 270)]
        [TestCase(new[] {1, 1, 1, 1}, ExpectedResult = 320)]
        [TestCase(new[] {1, 1, 1, 1, 1}, ExpectedResult = 375)]
        public int GetPriceForPottersTest(IEnumerable<int> bookAmounts)
        {
            var target = new PotterShoppingCart();
            return target.GetPriceForPotters(bookAmounts);
        }
    }
}