using System;

namespace Enum
{
    enum EnumType : byte
    {
        Zero,
        One,
        one = One,
        Two,
        Three,
        //Four
        Five,
        Infinite = 255
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EnumType digit = EnumType.Infinite;

            Type @enum = digit.GetType();
            Console.Write("Перечисление {0} состоит из элементов типа: ", @enum.Name);
            Type @const = Enum.GetUnderlyingType(@enum);
            Console.WriteLine(@const);

            // Another example.
            Console.Write("Перечисление EnumType состоит из элементов типа: ", @enum.Name);
            Console.WriteLine(Enum.GetUnderlyingType(typeof(EnumType)));

            Console.ReadKey();
        }
    }
}
