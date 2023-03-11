using System;

namespace Interfaces
{
    class Program
    {
        interface IInterface
        {
            void Method();
        }
        class MyClass : IInterface
        {
            public void Method()
            {
                Console.WriteLine("Метод - реализация Интерфейса");
            }
        }
        static void Main(string[] args)
        {
            IInterface my = new MyClass();

            my.Method();

            Console.ReadKey();
        }
    }
}
