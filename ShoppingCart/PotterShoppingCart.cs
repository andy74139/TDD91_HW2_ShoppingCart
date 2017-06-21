using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class PotterShoppingCart
    {
        private static readonly Dictionary<int, decimal> _Discount =
            new Dictionary<int, decimal>
            {
                {5, 0.75m},
                {4, 0.8m},
                {3, 0.9m},
                {2, 0.95m},
                {1, 1m}
            };

        private Dictionary<IPotterBook, int> _Books;

        public PotterShoppingCart()
        {
            ResetCart();
        }

        public void AddPotterBook(IPotterBook book, int amount)
        {
            if (book == null || amount <= 0)
                throw new ArgumentException();

            if (_Books.ContainsKey(book))
                _Books[book] += amount;
            else
                _Books[book] = amount;

            if (_Books.Count > 5)
                throw new ArgumentException();
        }

        public Dictionary<IPotterBook, int> GetCart()
        {
            return new Dictionary<IPotterBook, int>(_Books);
        }

        public void ResetCart()
        {
            _Books = new Dictionary<IPotterBook, int>();
        }

        public int Checkout()
        {
            var price = GetPriceInCart();
            ResetCart();
            return price;
        }

        public int GetPriceInCart()
        {
            var orderedBooks = _Books.OrderByDescending(b => b.Value);

            var price = 0;
            var lastCumulativeSeriesAmount = 0;
            for (var booksInOneSeries = orderedBooks.Count(); booksInOneSeries > 0; booksInOneSeries--)
            {
                var cumulativeSeriesAmount = orderedBooks.ElementAt(booksInOneSeries - 1).Value;
                var thisSeriesAmount = cumulativeSeriesAmount - lastCumulativeSeriesAmount;
                price += GetThisSeriesPrice(orderedBooks, booksInOneSeries) * thisSeriesAmount;

                lastCumulativeSeriesAmount = cumulativeSeriesAmount;
            }
            return price;
        }

        private static int GetThisSeriesPrice(IOrderedEnumerable<KeyValuePair<IPotterBook, int>> orderedBooks, int booksInOneSeries)
        {
            var totalPrice = orderedBooks.Skip(orderedBooks.Count() - booksInOneSeries).Select(b => b.Key.GetPrice()).Sum();
            return (int) (totalPrice*_Discount[booksInOneSeries]);
        }
    }
}