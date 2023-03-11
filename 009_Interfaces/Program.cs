using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface1 my = new DerivedClass();
            Interface2 my2 = new DerivedClass();

            my.Method();
            my2.Method();

            Console.ReadKey();
        }
    }
}
