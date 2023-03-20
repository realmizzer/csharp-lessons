using System;

namespace _005_Anonymous
{
    delegate void MyDelegate(string @string);

    internal class Program
    {

        static void Main()
        {
            var instance = new
            {
                MyDeledate = new MyDelegate((string @string) => Console.WriteLine(@string))
            };

            instance.MyDeledate.Invoke("Hello, World!");

            Console.ReadKey();
        }
    }
}
