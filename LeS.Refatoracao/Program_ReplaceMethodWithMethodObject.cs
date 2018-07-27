namespace LeS.Refatoracao
{
    class Program_ReplaceMethodWithMethodObject
    {
        static void Main(string[] args)
        {

        }
    }
    class Orders_Before
    {
        public double Price()
        {
            double primaryBasePrice;
            double secondaryBasePrice;
            double tertiaryBasePrice;
            
            return double.MinValue;
        }
    }
    public class Order_After
    {
        public double Price()
        {
            return new PriceCalculator(this).Compute();
        }
    }

    public class PriceCalculator
    {
        private double primaryBasePrice;
        private double secondaryBasePrice;
        private double tertiaryBasePrice;

        public PriceCalculator(Order_After order)
        {
            // code
        }

        public double Compute()
        {
            return double.MinValue;
        }
    }
}
