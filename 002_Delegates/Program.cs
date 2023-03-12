using System;

namespace _002_Delegates
{
    public delegate void MyDelegate();
    internal class Program
    {
        static void Method1()
        {
            Console.WriteLine("Method1");
        }
        static void Method2()
        {
            Console.WriteLine("Method2");
        }
        static void Method3()
        {
            Console.WriteLine("Method3");
        }
        static void Main()
        {
            // immutable type
            MyDelegate myDelegate = null;
            MyDelegate myDelegate1 = new MyDelegate(Method1);
            MyDelegate myDelegate2 = new MyDelegate(Method2);
            MyDelegate myDelegate3 = new MyDelegate(Method3);

            myDelegate = myDelegate1 + myDelegate2 + myDelegate3;

            myDelegate();

            Console.WriteLine(new string('-', 10));

            MyDelegate myDelegate4 = myDelegate - myDelegate1;

            myDelegate4();

            Console.WriteLine(new string('-', 10));

            myDelegate -= myDelegate2;
            myDelegate();

            Console.ReadKey();
        }
    }
}
