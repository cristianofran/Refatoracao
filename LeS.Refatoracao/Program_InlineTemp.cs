namespace LeS.Refatoracao
{
    class Program_InlineTemp
    {
        static void Main(string[] args)
        {

        }

        bool HasDiscount_Before(Order order)
        {
            var basePrice = order.BasePrice();
            return basePrice > 1000;
        }

        bool HasDiscount_After(Order order)
        {
            return order.BasePrice() > 1000;
        }
    }
    class Order
    {
        public double BasePrice()
        {
            return double.MinValue;
        }
    }
}
