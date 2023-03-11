using System;

namespace Interfaces
{
    class Program
    {
        interface IInterface1
        {
            void Method();
        }

        interface IInterface2 : IInterface1 
        {
            new void Method();
        }

        class ConcreteClass : IInterface2
        {
            void IInterface1.Method()
            {
                Console.WriteLine("IInterface1.Method()");
            }

            void IInterface2.Method()
            {
                Console.WriteLine("IInterface2.Method()");
            }

        }

        static void Main(string[] args)
        {
            ConcreteClass concrete = new ConcreteClass();

            IInterface1 interface1 = concrete as IInterface1;
            interface1.Method();

            IInterface2 interface2 = concrete as IInterface2;
            interface2.Method();

            Console.ReadKey();
        }
    }
}
