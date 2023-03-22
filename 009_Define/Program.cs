#define V7

using System;

namespace _009_Define
{
    internal class Program
    {
        static void Main()
        {
#if DEBUG && V7
            Console.WriteLine("Debug V7");
#endif

            Console.ReadKey();
        }
    }
}
