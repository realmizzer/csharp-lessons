using System;

namespace _001_Events
{
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate MyEvent = null;

        public void InvokeEvent()
        {
            Console.WriteLine("MyClass.MyEvent Invoked.");
            MyEvent.Invoke();
        }
    }

    class Program
    {
        // Методы обработчики события.
        static private void Handler1()
        {
            Console.WriteLine("Program.Method1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Program.Method2");
        }
        static private void Handler3()
        {
            Console.WriteLine("Program.Method3");
        }

        static void Main()
        {
            MyClass myClass = new MyClass();

            // Присоединение обработчиков событий (подписка).
            myClass.MyEvent += new EventDelegate(Handler1);
            
            // Предположение делагата.
            myClass.MyEvent += Handler2;
            myClass.MyEvent += Handler3;

            myClass.InvokeEvent();

            Console.WriteLine(new string('-', 10));

            // Открепляем обработчик (отписка).
            myClass.MyEvent -= Handler3;

            myClass.InvokeEvent();

            Console.ReadKey();
        }
    }
}
