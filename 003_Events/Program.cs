using System;

namespace _003_Events
{
    public delegate void EventDelegate();

    interface IInterface
    {
        event EventDelegate MyEvent;
    }

    public class BaseClass : IInterface
    {
        EventDelegate myEvent = null;

        // Защищённое событие.
        public virtual event EventDelegate MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }

    public class DerivedClass : BaseClass
    {
        public override event EventDelegate MyEvent
        { 
            add
            {
                base.MyEvent += value;
                Console.WriteLine("К событию базового класса был прикреплён обработчик - {0}", value.Method.Name);
            }
            remove
            {
                base.MyEvent -= value;
                Console.WriteLine("К событию базового класса был откреплён обработчик - {0}", value.Method.Name);
            }
        }
    }


    class Program
    {
        static private void Handler1()
        {
            Console.WriteLine("Program.Method1");
        }
        static private void Handler2()
        {
            Console.WriteLine("Program.Method2");
        }

        static void Main()
        {
            DerivedClass myClass = new DerivedClass();

            myClass.MyEvent += Handler1;
            myClass.MyEvent += Handler2;

            // Отписаться после будет невозможно.
            myClass.MyEvent += delegate { Console.WriteLine("Анонимный метод"); };

            myClass.InvokeEvent();

            Console.WriteLine(new string('-', 10));

            myClass.MyEvent -= Handler2;

            myClass.InvokeEvent();

            Console.ReadKey();
        }
    }
}
