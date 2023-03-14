using System;
using System.Threading;
namespace _001_Threads
{
    class Program
    {
        static void WriteSecond()
        {
            while(true)
            {
                Console.WriteLine(new string(' ', 10) + Thread.CurrentThread.Name);
            }
        }
        static void Main()
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond)
            {
                Name = "Thread.WriteSecond"
            };
            thread.Start();

            while(true)
            {
                Console.WriteLine("Thread.Main");
            }
        }
    }
}
