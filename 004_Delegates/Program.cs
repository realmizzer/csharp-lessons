using System;

namespace _004_Delegates
{
    public delegate int MyDelegate(int a);
    internal class Program
    {
        static void Main()
        {
            MyDelegate myDelegate;

            myDelegate = delegate (int x) { return x * 2; }; // lambda-method

            myDelegate = (x) => { return x * 2; }; // lambda-operator

            myDelegate = x => x * 2; // lambda-expression (выражение)

            int result = myDelegate(5);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
