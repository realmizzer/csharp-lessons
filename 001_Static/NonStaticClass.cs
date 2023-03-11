using System;

namespace Static
{
    internal class NonStaticClass
    {
        private int id;
        public static int field;

        public NonStaticClass(int id)
        {
            this.id = id;
        }

        public void Method()
        {
            Console.WriteLine("Instance{0}.field = {1}", id, field);
        }
    }
}
