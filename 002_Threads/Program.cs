using System;
using System.Threading;

namespace _002_Threads
{
    class Program
    {
        // Хоть этот метод и статичный, в разных потоках создаются копии данного метода,
        // поэтому их значения не совпадают.
        static void WriteSecond()
        {
            // CLR назначает каждому потоку свой стек с локальными переменными.
            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine("Thread Id {0}, counter = {1}", Thread.CurrentThread.GetHashCode(), counter);
                counter++;
            }

        }

        static void Main()
        {
            Thread thread = new Thread(WriteSecond);
            thread.Start();

            WriteSecond();

            Console.ReadKey();
        }
    }
}
