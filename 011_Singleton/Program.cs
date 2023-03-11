using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance();
            Singleton singleton2 = Singleton.Instance();

            if(singleton1 == singleton2)
                Console.WriteLine("Singletons have same links");

            Console.WriteLine(singleton1.GetHashCode());
            Console.WriteLine(singleton2.GetHashCode());

            Console.ReadKey();
        }
    }
}
