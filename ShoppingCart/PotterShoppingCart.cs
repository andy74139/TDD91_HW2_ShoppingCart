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
    }
}
