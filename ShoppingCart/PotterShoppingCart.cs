﻿using System;
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
            throw new NotImplementedException();
        }
    }
}
