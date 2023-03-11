using System;

namespace Params
{
    class Program
    {
        static void ShowArray(params int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
        static void Main()
        {
            ShowArray(0, 3, 2, 1, 5, 4);

            Console.ReadKey();
        }
    }
}
