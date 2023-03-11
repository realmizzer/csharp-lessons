using System;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NonStaticClass.Property);

            NonStaticClass.Property = 3;

            Console.WriteLine(NonStaticClass.Property);

            Console.ReadKey();
        }
    }
}
