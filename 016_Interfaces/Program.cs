using System;

namespace Interfaces
{
    class Program
    {
        interface IInterface
        {
            void Method();
        }
        class BaseClass
        {
            public void Method()
            {
                Console.WriteLine("BaseClass.Method() and IInterface.Method()");
            }
        }
        class DerivedClass : BaseClass, IInterface
        {
            // Реализация интерфейса не обязательна, так как
            // сигнатуры методов в классе и интерфейсе совпадают
        }

        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();

            instance.Method();

            Console.ReadKey();
        }
    }
}
