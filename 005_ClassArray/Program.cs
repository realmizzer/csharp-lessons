using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] vector = { 1, 2, 3 };

            Array array = vector as Array;

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }

            Console.ReadKey();
        }
    }
}
