using System;

namespace Structure
{
    // Structs can't be static.
    struct MyStruct
    {
        public static int Field { get; set; }

        public static void Show()
        {
            Console.WriteLine("Static Field {0}", Field);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static fields init unneccessary.

            // Struct places in stack and we can
            // work with them like with static items
            MyStruct.Field = 5;

            MyStruct.Show();

            Console.ReadKey();
        }
    }
}
