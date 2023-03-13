using System;

namespace _009_Nullable
{
    internal class Program
    {
        static void Main()
        {
            int? a = null;
            int? b = a + 4; // b = null
            int? c = a * 5; // c = null

            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
