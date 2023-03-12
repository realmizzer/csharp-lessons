using System;

namespace Enum
{
    enum EnumType
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
            Enum one = EnumType.One;
            Console.WriteLine(one);

            Console.WriteLine(new string('-', 10));

            for (EnumType number = EnumType.Zero; number <= EnumType.Three; number++)
            {
                Console.WriteLine("{0} - {1}", (int)number, number);
            }

            Console.ReadKey();
        }
    }
}
