using System;

namespace Enum
{
    enum EnumType
    {
        Zero,
        One,
        Two,
        Three,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EnumType five = (EnumType)5;

            Console.WriteLine(five);

            Console.ReadKey();
        }
    }
}
