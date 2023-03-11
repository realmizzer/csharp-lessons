using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();
            instance.Method1();
            instance.Method2();

            BaseClass instance0 = instance as BaseClass;
            instance0.Method();

            Interface1 instance1 = instance as Interface1;
            instance1.Method1();

            Interface2 instance2 = instance as Interface2;
            instance2.Method2();

            Console.ReadKey();
        }
    }
}
