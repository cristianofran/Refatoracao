using System;

namespace LeS.Refatoracao
{
    class Program_ExtractMethod
    {
        private string name = "Name 1";
        static void Main(string[] args)
        {
        }

        void Print_Before()
        {
            PrintBanner();
            
            // print details
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("amount: {0}", GetOutstanding());
        }

        void Print_After()
        {
            PrintBanner();
            PrintDetails(GetOutstanding());
        }

        void PrintDetails(double outstanding)
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("amount: {0}", outstanding);
        }

        private double GetOutstanding()
        {
            return double.MinValue;
        }

        private void PrintBanner()
        {
            // code
        }
    }
}
