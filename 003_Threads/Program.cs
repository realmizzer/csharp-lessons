using System;
using System.Threading;

namespace _003_Threads
{
    class Program
    {
        // Хоть этот метод и статичный, в разных потоках создаются копии данного метода,
        // поэтому их значения не совпадают.
        static void WriteSecond()
        {
            Thread thread = Thread.CurrentThread;

            thread.Name = "Secondary";

            Console.WriteLine("ID потока {0}: {1}", thread.Name, thread.GetHashCode());

            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(new string(' ', 15) + thread.Name + " " + counter);
                Thread.Sleep(1000);
            }

        }

        static void Main()
        {
            Thread primaryThread = Thread.CurrentThread;

            primaryThread.Name = "Primary";

            Console.WriteLine("ID потока {0}: {1}", primaryThread.Name, primaryThread.GetHashCode());

            // Требуется время на постройку потока. (1)
            Thread secondaryThread = new Thread(WriteSecond);
            secondaryThread.Start();

            // Поэтому цикл даже успевает проработать пару итераций. (2)
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(primaryThread.Name + " " + counter);
                Thread.Sleep(1500);
            }

            Console.ReadKey();
        }
    }
}
