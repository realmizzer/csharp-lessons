using System;

namespace _003_ConstraintNaked
{


    class MyClass<T, R, U> where T : U
    {

    }

    internal class Program
    {
        static void Main()
        {
            MyClass<int, object, ValueType> mc1 = new MyClass<int, object, ValueType>();

            // Не работает, т.к. int !: string.
            //MyClass<int, Object, string> mc2 = new MyClass<int, object, string>();

            Console.ReadKey();
        }
    }
}
