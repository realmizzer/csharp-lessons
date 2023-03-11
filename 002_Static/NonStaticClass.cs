using System;

namespace Static
{
    internal class NonStaticClass
    {
        private int id;

        public NonStaticClass(int id)
        {
            this.id = id;
        }

        public static void Method()
        {
            // Console.WriteLine("Instance{0}.field = {1}", id);

            Console.WriteLine("В статических методах нельзя обращаться к нестатическим полям.");
        }
    }
}
