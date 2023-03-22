// Вложенность пространств имён.

// namespace, как partial классы.
namespace NamespaceA
{
    namespace NamespaceB
    {
        namespace NamespaceC
        {
            class MyClassC
            {
                public void Method()
                {
                    System.Console.WriteLine("Hello, Namespaces!");
                }
            }
        }
        class MyClassB { }
    }
    class MyClassA { }
}


namespace _001_Namespaces
{
    // Псевдоним.
    using MyClass = NamespaceA.NamespaceB.NamespaceC.MyClassC;

    internal class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            myClass.Method();

            System.Console.WriteLine(typeof(MyClass));

            System.Console.ReadKey();
        }
    }
}
