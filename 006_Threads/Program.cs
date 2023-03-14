using System;
using System.Threading;

// Основные и фоновые потоки.
namespace _006_Threads
{
    class Program
    {
        static void WriteSecond()
        {
            while(true)
            {
                Console.WriteLine(new string(' ', 15) + "Secondary");
                Thread.Sleep(1500);
            }
        }

        static void Main()
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Primary");
                Thread.Sleep(500);
            }

            // true - не дожидаться конца работы потока.
            thread.IsBackground = true;
        }
    }
}
