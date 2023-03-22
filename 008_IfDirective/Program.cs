using System;

namespace _008_IfDirective
{
    internal class Program
    {
        static void Main()
        {
#if DEBUG
            Console.WriteLine("Debug Mode");
#endif

            Console.WriteLine("Hello, Directives!");

            Console.ReadKey();
        }
    }
}
