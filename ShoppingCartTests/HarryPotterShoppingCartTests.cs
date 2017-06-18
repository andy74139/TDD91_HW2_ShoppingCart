using NUnit.Framework;

namespace ShoppingCart.Tests
{
    [TestFixture]
    public class HarryPotterShoppingCartTests
    {
        [TestCase(1, ExpectedResult = 100)]
        public int GetPriceForPotterITest(int amount)
        {
            var target = new PotterShoppingCart();
            return target.GetPriceForPotterI(amount);
        }
    }
}
