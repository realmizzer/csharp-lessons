using System;

namespace Structure
{
    // Structs can't be static.
    struct MyStruct
    {
        public int field;

        // Works only with custom constructor
        // and don't work with constructor with init.
        static MyStruct()
        {
            Console.WriteLine("Static Constructor");
        }

        public MyStruct(int value)
        {
            Console.WriteLine("Constructor");
            field = value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyStruct @struct = new MyStruct(33);
            MyStruct @struct = new MyStruct { field = 1 };

            Console.WriteLine(@struct.field);

            Console.ReadKey();
        }
    }
}
