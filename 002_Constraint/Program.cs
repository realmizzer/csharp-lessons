using System;
namespace _002_Constraint
{
    interface IInterface { }
    interface IInterface<T> : IInterface { }

    class Derived : IInterface, IInterface<object> { }

    class Derived2 : IInterface<object> { }


    class MyClass<T> where T : IInterface, IInterface<object> { }

    class MyClass2<T> where T : IInterface<object> { }

    internal class Program
    {
        static void Main()
        {
            MyClass<Derived> mc1 = new MyClass<Derived>();

            MyClass<IInterface<object>> mc2 = new MyClass<IInterface<object>>();

            MyClass2<Derived> mc3 = new MyClass2<Derived>();
            MyClass2<Derived2> mc4 = new MyClass2<Derived2>();
            MyClass2<IInterface<object>> mc5 = new MyClass2<IInterface<object>>();

            Console.ReadKey();
        }
    }
}
