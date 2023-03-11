using System;

namespace Structure
{
    struct MyStruct
    {
        public int MyProperty { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct(); // <-

            // This code won't work without constructor call.
            myStruct.MyProperty = 1;
            Console.WriteLine(myStruct.MyProperty);

            Console.ReadKey();
        }
    }
}
