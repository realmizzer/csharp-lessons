using System;

namespace _010_Nullable
{
    internal class Program
    {
        static void Main()
        {
            int? a = null;
            int? b = -5;

            // Всегда False, т.к. нет смысла в сравнении с null.
            if(a >= b)
            {
                Console.WriteLine("a >= b");
            }
        }
    }
}
