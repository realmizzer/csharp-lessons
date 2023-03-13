using System;

namespace _001_NewConstraint
{
    class MyClass<T> where T : new()
    {
        public T instance = new T();

        public void GetValues()
        {
            Console.WriteLine(instance.ToString());
        }
    }

    class TestClass
    {
        public int MyIntProperty { get; set; }
        public string MyStringProperty { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", MyIntProperty, MyStringProperty);
        }
    }

    internal class Program
    {
        static void Main()
        {
            MyClass<TestClass> myClass = new MyClass<TestClass>();
            myClass.instance.MyIntProperty = 1;
            myClass.instance.MyStringProperty = "is number.";

            Console.WriteLine(myClass.ToString());

            myClass.GetValues();

            Console.ReadKey();
        }
    }
}
