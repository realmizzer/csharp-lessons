using System;

namespace Yield
{
    class Program
    {
        static void Main()
        {
            foreach (string element in CustomCollection.Power())
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
