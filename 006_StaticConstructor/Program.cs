using System;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NonStaticClass instance = new NonStaticClass();

            instance.NonStaticMethod();

            NonStaticClass.Method();
            NonStaticClass.Method(3);

            Console.ReadKey();
        }
    }
}
