using System;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NonStaticClass.ReadonlyField);

            Console.ReadKey();
        }
    }
}
