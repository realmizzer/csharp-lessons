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

namespace NamespaceA.NamespaceB.NamespaceC
{
    class NewMyClass
    {

    }
}

namespace _003_Namespaces
{
    internal class Program
    {
        static void Main()
        {
            NamespaceA.NamespaceB.NamespaceC.MyClassC myClass = new NamespaceA.NamespaceB.NamespaceC.MyClassC();
            NamespaceA.NamespaceB.NamespaceC.NewMyClass newMyClass = new NamespaceA.NamespaceB.NamespaceC.NewMyClass();

            System.Console.WriteLine(myClass.GetType());
            System.Console.WriteLine(newMyClass.GetType());

            System.Console.ReadKey();
        }
    }
}
