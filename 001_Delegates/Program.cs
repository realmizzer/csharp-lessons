using System;

namespace _001_Delegates
{
    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Hello from delegate!");
        }
    }

    public delegate void MyDelegate();

    internal class Program
    {
        static void Main()
        {
            MyDelegate myDelegate = new MyDelegate(MyClass.Method);

            myDelegate?.Invoke();

            myDelegate();

            Console.ReadKey();
        }
    }
}
