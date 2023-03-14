using System;
using System.Threading;

namespace _009_CriticalSection
{
    class Program
    {
        readonly static object locker = new object();

        static void WriteSecond()
        {
            for (int i = 0; i < 20; i++)
            {
                lock (locker)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string(' ', 10) + "Secondary");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(100);
                }
            }
        }

        static void Main()
        {
            Thread thread = new Thread(WriteSecond);
            thread.Start();

            for(int i = 0; i < 20; i++)
            {
                lock (locker)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Primary");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(100);
                }
            }

            Console.ReadKey();
        }
    }
}
