namespace MyNamespace
{
    // Импорт пространства имён.
    using System;

    namespace MyNamespace
    {
        class MyClass
        {
            public void Method()
            {
                Console.WriteLine("Hello, Namespaces!");
            }
        }
    }
}

namespace _002_Namespaces
{
    internal class Program
    {
        static void Main()
        {
            MyNamespace.MyNamespace.MyClass myClass = new MyNamespace.MyNamespace.MyClass();

            myClass.Method();
            System.Console.WriteLine(myClass.GetType());

            System.Console.ReadKey();
        }
    }
}
