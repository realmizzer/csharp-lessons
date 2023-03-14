using System;

namespace Params
{
    class Program
    {
        // params всегда стоит в конце всех передаваемых параметров 
        static void ShowArray(string name, params int[] array)
        {
            Console.Write(name);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
        static void Main()
        {
            ShowArray("Numbers: ", 0, 3, 2, 1, 5, 4);

            Console.ReadKey();
        }
    }
}
