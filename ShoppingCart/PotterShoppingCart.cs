using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    public class PotterShoppingCart
    {
        public int GetPriceForPotterI(int amount)
        {
            return 100*amount;
        }

        public int GetPriceForPotterOneTwo(int amount1, int amount2)
        {
            var seriesAmount = Math.Min(amount1, amount2);
            var oneBookAmount = Math.Max(amount1, amount2) - seriesAmount;

            return ((int) (100*2*0.95m))*seriesAmount + 100*oneBookAmount;
        }

        public int GetPriceForPotters(IEnumerable<int> bookAmounts)
        {
            if(bookAmounts.Count() != 4)
                throw new ArgumentException("Length of bookAmounts must be 4");

            var sortedAmounts = bookAmounts.ToArray();
            Array.Sort(sortedAmounts);

            var fourSeriesPrice = sortedAmounts[0]*((int) (100*4*0.8m));
            var threeSeriesPrice = (sortedAmounts[1] - sortedAmounts[0])*((int) (100*3*0.9m));
            var twoSeriesPrice = (sortedAmounts[2] - sortedAmounts[1])*((int) (100*2*0.95m));
            var oneBookPrice = (sortedAmounts[3] - sortedAmounts[2])*100;

            return fourSeriesPrice + threeSeriesPrice + twoSeriesPrice + oneBookPrice;
        }
    }
}
