using System;

namespace Structure
{
    struct MyStruct
    {
        public int field;

        // Struct can't declare constructor by default clearly
        // but it works anyway.
        //public MyStruct()
        //{

        //}

        // Custom constructor must init all fields.
        public MyStruct(int value)
        {
            Console.WriteLine("Constructor");
            this.field = value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct @struct = new MyStruct();
            MyStruct @struct2 = new MyStruct(3);

            Console.WriteLine(@struct2.field);

            Console.ReadKey();
        }
    }
}
