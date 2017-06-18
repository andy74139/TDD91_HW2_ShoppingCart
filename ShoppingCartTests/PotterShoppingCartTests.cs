using NUnit.Framework;
using ShoppingCart;

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
    }
}
