using System;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NonStaticClass instance = new NonStaticClass(1);
            NonStaticClass instance2 = new NonStaticClass(2);

            instance.Method();
            instance2.Method();

            // класс-объект
            NonStaticClass.field = 1;

            instance.Method();
            instance2.Method();

            Console.ReadKey();
        }
    }
}
