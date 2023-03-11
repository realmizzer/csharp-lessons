using System;

namespace Interfaces
{
    class Program
    {
        interface IInterface1
        {
            void Method();
        }
        // Наследование от интерфейса (абстрактный метод инт)
        abstract class AbstractClass : IInterface1
        {
            // Замещение метода из интерфейса в абстрактном классе
            public abstract void Method();
        }
        class ConcreteClass : AbstractClass
        {
            // Реализация абстрактного метода из абстрактного класса (override or not)
            public override void Method()
            {
                Console.WriteLine("Abstract IInterface Concrete.Method()");
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
