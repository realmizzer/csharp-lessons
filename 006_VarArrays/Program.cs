using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            var array1 = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(array1.GetType());

            var array2 = new[] { 3.1245, 1, 6 };
            Console.WriteLine(array2.GetType());

            // var - это не тип
            // var array3 = new[] { 1, "string" };

            Console.ReadKey();
        }
    }
}
