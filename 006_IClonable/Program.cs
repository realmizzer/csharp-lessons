using System;
using System.Diagnostics;
using System.Threading;

namespace _006_IClonable
{
    // 1:06
    public class MyClass : ICloneable
    {
        int a, b;

        public MyClass()
        {
            Thread.Sleep(1000);
            a = new Random().Next(1, 100);
            Thread.Sleep(1000);
            b = new Random().Next(1, 100);
        }

        public object Clone()
        {
            // Это быстрее.
            return this.MemberwiseClone();
            // return new MyClass();
        }
    }


    internal class Program
    {
        static void Main()
        {
            Stopwatch timer = new Stopwatch();

            timer.Start();
            MyClass original = new MyClass();
            timer.Stop();
            Console.WriteLine("Original builded for {0}", timer.Elapsed.Ticks);

            timer.Reset();

            timer.Start();
            MyClass clone = original.Clone() as MyClass;
            timer.Stop();
            Console.WriteLine("Clone builded for {0}", timer.Elapsed.Ticks);

            Console.ReadKey();
        }
    }
}
