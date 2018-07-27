namespace LeS.Refatoracao
{
    class Program_RemoveAssignmentsToParameters
    {
        static void Main(string[] args)
        {

        }

        int Discount_Before(int inputVal)
        {
            if (inputVal > 50)
            {
                inputVal -= 2;
            }
            return inputVal;
        }

        int Discount_After(int inputVal)
        {
            var result = inputVal;
            if (inputVal > 50)
            {
                result -= 2;
            }
            return result;
        }
    }
}
