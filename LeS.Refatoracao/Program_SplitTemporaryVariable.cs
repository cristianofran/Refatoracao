using System;

namespace LeS.Refatoracao
{
    class Program_SplitTemporaryVariable
    {
        private double height;
        private double width;
        static void Main(string[] args)
        {

        }

        void Before()
        {
            var temp = 2 * (height + width);
            Console.WriteLine(temp);
            temp = height * width;
            Console.WriteLine(temp);
        }

        void After()
        {
            var perimeter = 2 * (height + width);
            Console.WriteLine(perimeter);
            var area = height * width;
            Console.WriteLine(area);
        }
    }
}
