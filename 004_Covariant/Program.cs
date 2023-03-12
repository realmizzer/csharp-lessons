using System;

// Contradiction between system types CLI and C#.
namespace _004_Covariant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint[] array = new uint[3];

            Console.WriteLine("array {0} {1}", array is uint[], array is int);

            object @object = array;

            Console.WriteLine("object {0} {1}", @object is uint[], @object is int);

            Console.ReadKey();
        }
    }
}
