using System;

namespace _001_Generics
{
    delegate R MyDelegate<T, R>(T t);

    internal class Program
    {
        public static int Add(int i)
        {
            return ++i;
        }
        public static string Concatenation(string s)
        {
            return "Hello " + s + "!";
        }

        static void Main()
        {
            MyDelegate<int, int> myDelegate = new MyDelegate<int, int>(Add);
            int i = myDelegate.Invoke(1);
            Console.WriteLine(i);

            MyDelegate<string, string> stringDelegate = new MyDelegate<string, string>(Concatenation);
            string text = stringDelegate.Invoke("Max");
            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}
