using System;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = AbstractClass.CreateObject();
            instance.Method();

            Console.ReadKey();
        }
    }
}
