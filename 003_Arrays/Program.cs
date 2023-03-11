using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[,,] threeDim =
            {
                {
                    {1, 2}, {3, 4},
                },
                {
                    {5, 6}, {7, 8}
                }
            };

            for(int i = 0; i < threeDim.GetLength(0); ++i)
            {
                for(int j = 0; j < threeDim.GetLength(1); ++j)
                {
                    for(int k = 0; k < threeDim.GetLength(2); k++)
                    {
                        Console.Write(threeDim[i, j, k] + ", ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Array Length: {0}", threeDim.Length);

            Console.ReadKey();
        }
    }
}
