using System;

namespace Interfaces
{
    class Program
    {
        interface IInterface1
        {
            void Method();
        }
        abstract class AbstractClass : IInterface1
        {
            public void Method()
            {
                Console.WriteLine("Abstract IInterface1.Method()");
            }
        }
        class ConcreteClass : AbstractClass
        {

        }
        static void Main(string[] args)
        {
            AbstractClass concrete = new ConcreteClass();

            concrete.Method();

            Console.ReadKey();
        }
    }
}
