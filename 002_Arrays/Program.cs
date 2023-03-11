using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            Random random = new();

            int[,] array = new int[3, 3];

            for(int i = 0; i < array.GetLength(array.Rank - 1); i++)
            {
                for(int j = 0; j < array.GetLength(array.Rank - 1); j++)
                {
                    array[i, j] = random.Next(0, 10);
                }
            }

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(array[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}
