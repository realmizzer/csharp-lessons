using System;

namespace Static
{
    internal class Program
    {
        class BaseClass
        {
            // Static method can't be virtual, overrided or abstract.
            public static void StaticMethod()
            {
                Console.WriteLine("BaseClass.StaticMethod");
            }
        }

        class DerivedClass : BaseClass
        {
            // Static methods can be only replaced.
            public static new void StaticMethod()
            {
                Console.WriteLine("DerivedClass.StaticMethod");
            }
        }

        static void Main(string[] args)
        {
            BaseClass.StaticMethod();
            DerivedClass.StaticMethod();

            Console.ReadKey();
        }
    }
}
