using System;

namespace Enum
{
    enum EnumType : byte
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EnumType.Zero);
            Console.WriteLine((byte)EnumType.Zero);

            EnumType digit = EnumType.One;

            Console.WriteLine(digit);
            Console.WriteLine((byte)digit);

            Console.ReadKey();
        }
    }
}
