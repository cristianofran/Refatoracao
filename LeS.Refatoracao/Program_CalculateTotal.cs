namespace LeS.Refatoracao
{
    class Program_CalculateTotal
    {
        private double quantity;
        private double itemPrice;

        static void Main(string[] args)
        {

        }

        double CalculateTotal_Before()
        {
            double basePrice = quantity * itemPrice;
            if (basePrice > 1000)
                return basePrice * 0.95;
            return basePrice * 0.98;
        }

        double CalculateTotal_After()
        {
            if (BasePrice() > 1000)
                return BasePrice() * 0.95;
            return BasePrice() * 0.98;
        }

        private double BasePrice()
        {
            return quantity * itemPrice;
        }
    }
}
