using System.Collections.Generic;

namespace LeS.Refatoracao
{
    class Program_FoundPerson
    {
        static void Main(string[] args)
        {

        }
        string FoundPerson_Before(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    return "Don";
                }
                if (people[i].Equals("John"))
                {
                    return "John";
                }
                if (people[i].Equals("Kent"))
                {
                    return "Kent";
                }
            }
            return string.Empty;
        }

        string FoundPerson_After(string[] people)
        {
            var candidates = new List<string> {"Don", "John", "Kent"};
            foreach (var p in people)
            {
                if (candidates.Contains(p))
                {
                    return p;
                }
            }
            return string.Empty;
        }
    }
}
