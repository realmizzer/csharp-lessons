using System;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NonStaticClass instance = new NonStaticClass(1);

            NonStaticClass.Method();

            Console.ReadKey();
        }
    }
}
