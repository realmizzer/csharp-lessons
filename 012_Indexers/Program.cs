using System;

namespace Indexers
{
    class MyClass
    {
        private readonly string[] array = new string[5];

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
            set
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
                else
                    Console.WriteLine("Попытка записи за пределами массива.");
            }
        }

    }

    class Program
    {
        static void Main()
        {
            MyClass my = new();

            for(int i = 0; i < 6; i++)
            {
                my[i] = string.Format("string {0}", i);
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(my[i]);
            }

            Console.ReadKey();
        }
    }
}
