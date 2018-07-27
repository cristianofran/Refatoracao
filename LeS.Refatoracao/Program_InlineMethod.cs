namespace LeS.Refatoracao
{
    class Program_InlineMethod
    {
        static void Main(string[] args)
        {
        }
    }

    class PizzaDelivery_Before
    {
        int numberOfLateDeliveries = 0;
        int GetRating()
        {
            return MoreThanFiveLateDeliveries() ? 2 : 1;
        }
        bool MoreThanFiveLateDeliveries()
        {
            return numberOfLateDeliveries > 5;
        }
    }

    class PizzaDelivery_After
    {
        int numberOfLateDeliveries = 0;
        int GetRating()
        {
            return numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }


    
}
