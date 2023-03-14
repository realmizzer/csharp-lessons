using System;

namespace Interfaces
{
    class Program
    {

        static void Main(string[] args)
        {
            Interface1 interface1 = new DerivedClass();
            Interface2 interface2 = new DerivedClass();

            interface1.Method1();
            interface2.Method2();

            Console.ReadKey();
        }
    }
}
