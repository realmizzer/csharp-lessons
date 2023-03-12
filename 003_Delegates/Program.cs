using System;

namespace _003_Delegates
{
    public delegate int MyDelegate(int a, int b);
    internal class Program
    {
        static void Main()
        {
            // anonymous (lambda) method
            MyDelegate myDelegate = delegate(int a, int b) { return a + b; };

            int summand1 = 1;
            int summand2 = 2;

            int sum = myDelegate(summand1, summand2);

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
