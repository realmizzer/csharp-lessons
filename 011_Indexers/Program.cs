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
            MyClass myClass = new();

            myClass[0] = "Привет, ";
            myClass[1] = "Мир!";
            //myClass[6] = "a";

            Console.WriteLine(myClass[0]);
            Console.WriteLine(myClass[1]);
            Console.WriteLine(myClass[2]);

            Console.ReadKey();
        }
    }
}
