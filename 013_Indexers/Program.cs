using System;

namespace Indexers
{
    class Program
    {
        class MyClass
        {
            private readonly int[,] array = new int[3, 3];

            public int this[int index1, int index2]
            {
                get
                {
                    return array[index1, index2];
                }
                set
                {
                    array[index1, index2] = value;
                }
            }
        }

        static void Main()
        {
            MyClass my = new();

            my[1, 1] = 2;

            Console.WriteLine(my[1, 1]);
            Console.WriteLine(my[0, 0]);

            Console.ReadKey();
        }
    }
}
