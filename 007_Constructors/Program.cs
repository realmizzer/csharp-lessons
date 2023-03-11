using System;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NonStaticClass.StaticMethod();

            // Weak link
            new NonStaticClass().NonStaticMethod();

            Console.ReadKey();
        }
    }
}
