using System;

namespace Abstraction
{
    abstract class AbstractBaseClass
    {
        public void SimpleMethod()
        {
            Console.WriteLine("AbstractBaseClass.SimpleMethod");
        }

        // переопределение в производном
        public virtual void VirtualMethod()
        {
            Console.WriteLine("AbstractBaseClass. VirtualMethod");
        }

        // в производном классе мы его реализуем, абстрактного метода не существует, это на самом деле virtual
        public abstract void AbstractMethod();
    }
}
