using System;

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            DerivedClass derivedClass = new();

            // полиморфизм через виртуальные методы
            BaseClass baseClass = derivedClass as BaseClass;

            Console.WriteLine(baseClass[0]);
            Console.WriteLine(baseClass[1]);
            Console.WriteLine(baseClass[2]);

            Console.ReadKey();
        }
    }
}
