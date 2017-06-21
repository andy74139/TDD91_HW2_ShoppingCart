namespace ShoppingCart
{
    public interface IPotterBook
    {
        int GetPrice();
    }

    public class PotterBookI : IPotterBook
    {
        private readonly int _Price;

        public PotterBookI(int price)
        {
            _Price = price;
        }

        public int GetPrice()
        {
            return _Price;
        }
    }

    public class PotterBookII : IPotterBook
    {
        private readonly int _Price;

        public PotterBookII(int price)
        {
            _Price = price;
        }

        public int GetPrice()
        {
            return _Price;
        }
    }


    public class PotterBookIII : IPotterBook
    {
        private readonly int _Price;

        public PotterBookIII(int price)
        {
            _Price = price;
        }

        public int GetPrice()
        {
            return _Price;
        }
    }


    public class PotterBookIV : IPotterBook
    {
        private readonly int _Price;

        public PotterBookIV(int price)
        {
            _Price = price;
        }

        public int GetPrice()
        {
            return _Price;
        }
    }


    public class PotterBookV : IPotterBook
    {
        private readonly int _Price;

        public PotterBookV(int price)
        {
            _Price = price;
        }

        public int GetPrice()
        {
            return _Price;
        }
    }

}