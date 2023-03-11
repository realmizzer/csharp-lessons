using System;

namespace Interfaces
{
    class Program
    {
        interface IInterface1
        {
            void Method();
        }
        interface IInterface2
        {
            void Method();
        }
        class ConcreteClass : IInterface1, IInterface2
        { 
            // объединение реализаций одноимённых членов интерфейса
            public void Method()
            {
                Console.WriteLine("IInterfac1-2.Method()");
            }
        }
        static void Main(string[] args)
        {
            ConcreteClass concrete = new ConcreteClass();

            concrete.Method();

            Console.ReadKey();
        }
    }
}
