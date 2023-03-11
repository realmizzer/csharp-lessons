using System;

namespace Structure
{
    
    struct MyStruct
    {
        private int field;

        public int Field
        {
            get => field;
            set => field = value;
        }

        // Struct has methods only in OOP lng like c#
        public void Show()
        {
            Console.WriteLine(field);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Keyword 'new' means create instance in heep
            // 'structure' appears in stack but will refer to heep
            MyStruct structure = new MyStruct();

            // Now, if we comment this, compilator will done his work anyway.
            // because was called constructor by default
            structure.Field = 1; 

            structure.Show();

            Console.ReadKey();
        }
    }
}
