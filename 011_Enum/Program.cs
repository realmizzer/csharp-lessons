using System;

namespace _011_Enum
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
            Array array = Enum.GetValues(typeof(EnumType));

            Console.WriteLine("Длина массива из элементов перечисления: " + array.Length + "\n");

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine("Имя константы {0} - значение {0:D}", array.GetValue(i));

            Console.ReadKey();
        }
    }
}
