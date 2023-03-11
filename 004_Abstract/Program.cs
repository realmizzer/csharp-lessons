using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBaseClass instance = new DerivedClass();

            instance.AbstractMethod();
            instance.VirtualMethod();

            Console.ReadKey();
        }
    }
}
