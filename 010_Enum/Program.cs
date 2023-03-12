using System;

namespace Enum
{
    enum EnumType
    {
        Zero,
        One,
        Two,
        Three,
        Infinite = int.MaxValue
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            object element = Enum.Parse(typeof(EnumType), "Infinite");
            EnumType number = (EnumType)element;

            Console.WriteLine("Значение константы {0} - {1}", number, (int)number);

            bool flag = Enum.IsDefined(typeof(EnumType), "Zero");

            if(flag) Console.WriteLine("Zero exists");
            else Console.WriteLine("Zero doesn't exist");

            Console.ReadKey();
        }
    }
}
