using System;

namespace Abstract
{
    internal class ConcreteClass : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Overrided Method from AbstractClass. Instance from ConcreteClass");
        }
    }
}
