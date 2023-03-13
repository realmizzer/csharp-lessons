using System;

namespace _012_Nullable
{
    internal class Program
    {
        static void Main()
        {
            Nullable<int> a = 1;

            if(a.HasValue == true)
            {
                Console.WriteLine("a is {0}.", a.Value);
            }

            int? b = 1;

            if(b.HasValue == true)
            {
                Console.WriteLine("b is {0}", b);
            }

            // var? c = null;

            Console.ReadKey();
        }
    }
}
