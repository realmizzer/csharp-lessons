using System;
using System.Collections;

namespace Homework.Numbers
{
    internal class Program
    {
        static readonly int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

        static void Main()
        {
            foreach (var result in SquareArray(numbers))
            {
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }

        private static IEnumerable SquareArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    yield return numbers[i] * numbers[i];
                }
            }
        }
    }
}
