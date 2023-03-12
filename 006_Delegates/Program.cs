using System;

namespace _006_Delegates
{
    delegate MyDelegate Functional(MyDelegate myDelegate1, MyDelegate myDelegate2);
    delegate string MyDelegate();

    internal class Program
    {
        static void Main()
        {
            MyDelegate myDelegate1 = () => "Hello, ";
            MyDelegate myDelegate2 = () => "delegates!";

            //Functional functional = delegate (MyDelegate d1, MyDelegate d2)
            //{
            //    return delegate { return d1() + d2(); };
            //};

            Functional functional = (MyDelegate d1, MyDelegate d2) => () => d1() + d2();

            Console.WriteLine(functional(myDelegate1, myDelegate2).Invoke());
        }
    }
}
