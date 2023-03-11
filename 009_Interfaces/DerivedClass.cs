using System;

namespace Interfaces
{
    public class DerivedClass : Interface1, Interface2
    {
        // данные методы доступны, если апкастить к этим интерфейсам
        void Interface1.Method()
        {
            Console.WriteLine("Interface1.Method()");
        }

        void Interface2.Method()
        {
            Console.WriteLine("Interface2.Method()");
        }
    }
}
