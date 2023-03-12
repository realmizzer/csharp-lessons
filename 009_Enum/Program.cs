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
            Console.WriteLine("Hex: {0}", Enum.Format(typeof(EnumType), EnumType.Three, "x"));
            Console.WriteLine("Hex: {0}", Enum.Format(typeof(EnumType), EnumType.Three, "D"));
            Console.WriteLine("Hex: {0}", Enum.Format(typeof(EnumType), EnumType.Three, "G"));
        }
    }
}
