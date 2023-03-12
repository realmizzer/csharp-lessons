using System;

// Boxing is convertation from value type in reference
// Unboxing is convertation from reference type to value

namespace _001_Boxing
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int @int = 1;

            // Boxing
            object obj = @int;

            // Unboxing
            int a = (int)obj;

            // Unboxing
            // long b = (long)obj;

            Console.WriteLine(a.GetType());

            Console.ReadKey();
        }
    }
}
