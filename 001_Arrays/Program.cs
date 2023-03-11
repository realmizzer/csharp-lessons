using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // способы инициализации массива
            int[] array = { 1, 2, 3, 4, 5 }; // Блок инициализатора
            array = new int[5];
            array = new int[5] { 1, 2, 3, 4, 5 };
            array = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
