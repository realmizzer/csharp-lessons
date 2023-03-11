using System;

namespace Interfaces
{
    class Program
    {
        // узкий интерфейс
        interface IInterface1
        {
            void Method1();
        }

        // широкий интерфейс
        interface IInterface2 : IInterface1
        {
            void Method2();
        }

        class ConcreteClass : IInterface2
        {
            public void Method1()
            {
                Console.WriteLine("IInterface1.Method1()");
            }

            public void Method2()
            {
                Console.WriteLine("IInterface2.Method2()");
            }
        }
        static void Main(string[] args)
        {
            ConcreteClass concrete = new ConcreteClass();
            concrete.Method1();
            concrete.Method2();

            IInterface1 interface1 = concrete as IInterface1;
            interface1.Method1();

            IInterface2 interface2 = concrete as IInterface2;
            interface2.Method2();

            Console.ReadKey();
        }
    }
}
