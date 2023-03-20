using System;

namespace _004_Anonymous
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
            // Слабая ссылка.
            new
            {
                My = new MyClass { field = 1 }
            }.My.Method();

            Console.ReadKey();
        }
    }
}
