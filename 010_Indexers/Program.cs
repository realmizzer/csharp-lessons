using System;

namespace Indexers
{
    class MyClass
    {
        private readonly int[] array = new int[5];

        // Индексатор
        public int this[int index]
        {
            get     // Аксессор
            {
                return array[index];
            }
            set     // Мутатор
            {
                array[index] = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass myClass = new();

            myClass[0] = 1;
            myClass[1] = 2;
            myClass[2] = 3;
            myClass[3] = 4;
            myClass[4] = 5;

            for(int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", myClass[i]);
            }

            Console.ReadKey();
        }
    }
}
