using System;

namespace _002_Events
{
    public delegate void EventDelegate();

    public class MyClass
    {
        EventDelegate myEvent = null;

        public event EventDelegate MyEvent
        { 
            add { myEvent += value; }
            remove { Console.WriteLine(value); }
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
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
            MyClass myClass = new MyClass();

            myClass.MyEvent += Handler1;
            myClass.MyEvent += Handler2;

            myClass.InvokeEvent();

            myClass.MyEvent -= Handler2;

            Console.ReadKey();
        }
    }
}
