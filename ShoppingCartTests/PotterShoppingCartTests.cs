using System.Collections.Generic;
using NUnit.Framework;

namespace ShoppingCart.Tests
{
    [TestFixture]
    public class PotterShoppingCartTests
    {
        private List<IPotterBook> Potters;
        private PotterBookI PotterI;
        private PotterBookII PotterII;
        private PotterBookIII PotterIII;
        private PotterBookIV PotterIV;
        private PotterBookV PotterV;

        [SetUp]
        public void SetUp()
        {
            PotterI = new PotterBookI(100);
            PotterII = new PotterBookII(100);
            PotterIII = new PotterBookIII(100);
            PotterIV = new PotterBookIV(100);
            PotterV = new PotterBookV(100);

            Potters = new List<IPotterBook>
            {
                PotterI, 
                PotterII, 
                PotterIII, 
                PotterIV, 
                PotterV
            };
        }

        [TestCase(new[] {1, 0, 0, 0, 0}, ExpectedResult = 100, TestName = "GetPriceForPottersTest_BuyPotterOne_ShouldBe100")]
        [TestCase(new[] {1, 1, 0, 0, 0}, ExpectedResult = 190, TestName = "GetPriceForPottersTest_BuyPotterTwoSeries_ShouldBe190")]
        [TestCase(new[] {1, 1, 1, 0, 0}, ExpectedResult = 270, TestName = "GetPriceForPottersTest_BuyPotterThreeSeries_ShouldBe270")]
        [TestCase(new[] {1, 1, 1, 1, 0}, ExpectedResult = 320, TestName = "GetPriceForPottersTest_BuyPotterFourSeries_ShouldBe320")]
        [TestCase(new[] {1, 1, 1, 1, 1}, ExpectedResult = 375, TestName = "GetPriceForPottersTest_BuyPotterFiveSeries_ShouldBe375")]
        [TestCase(new[] {1, 1, 2, 0, 0}, ExpectedResult = 370, TestName = "GetPriceForPottersTest_BuyPotterOneAndThreeSeries_ShouldBe370")]
        [TestCase(new[] {1, 2, 2, 0, 0}, ExpectedResult = 460, TestName = "GetPriceForPottersTest_BuyPotterTwoSeriesAndThreeSeries_ShouldBe460")]
        [TestCase(new[] {2, 0, 1, 0, 2}, ExpectedResult = 460, TestName = "GetPriceForPottersTest_BuyPotterTwoSeriesAndThreeSeriesWithourOrder_ShouldBe460")]
        [TestCase(new[] {1, 2, 3, 4, 5}, ExpectedResult = 1255, TestName = "GetPriceForPottersTest_BuyPotterOneEachSeries_ShouldBe1255")]
        [TestCase(new[] {4, 3, 6, 1, 7}, ExpectedResult = 1765, TestName = "GetPriceForPottersTest_BuyPotterEachSeries_ShouldBe1765")]
        public int GetPriceForPottersTest(int[] bookAmounts)
        {
            var target = new PotterShoppingCart();
            for (var i = 0; i < 5; i++)
            {
                if (bookAmounts[i] > 0)
                    target.AddPotterBook(Potters[i], bookAmounts[i]);
            }

            return target.Checkout();
        }
    }
}