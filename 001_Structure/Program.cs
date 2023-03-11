using System;

namespace Structure
{
    struct MyStruct
    {
        // Can't initalize value in structure fields
        public int field;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct structure;

            structure.field = 1; // comment it for check

            Console.WriteLine(structure.field); // p.s. it won't work

            Console.ReadKey();
        }
    }
}
