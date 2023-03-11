using System;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("e = {0}", NonStaticClass.e);

            Console.ReadKey();
        }
    }
}
