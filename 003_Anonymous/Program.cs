using System;

namespace _003_Anonymous
{
    class MyClass
    {
        public int field;

        public void Method()
        {
            Console.WriteLine(field);
        }
    }

    internal class Program
    {
        static void Main()
        {
            var instance = new { @class = new MyClass() };

            instance.@class.field = 2;
            instance.@class.Method();

            Console.ReadKey();
        }
    }
}
