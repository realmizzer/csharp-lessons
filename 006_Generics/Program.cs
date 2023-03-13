using System;

// Только Интерфейсы и Делегаты могут поддерживать
// Ковариатность и Контрвариатность типов.

namespace _006_Generics
{
    public abstract class Shape { }
    public class Circle : Shape { }

    // Контрвариатность.
    public interface IContainer<in T>
    {
        T Figure { set; }
    }

    public class Container<T> : IContainer<T>
    {
        private T figure;

        public Container(T figure)
        {
            this.figure = figure;
        }

        public T Figure
        {
            set => this.figure = value;
        }

        public override string ToString()
        {
            return figure.GetType().ToString();
        }
    }

    internal class Program
    {
        static void Main()
        {
            Shape circle = new Circle();

            // Контрвариатность обобщений.
            // Downcast параметра типа.
            IContainer<Circle> container = new Container<Shape>(circle);

            Console.WriteLine(container.ToString());


            Console.ReadKey();
        }
    }
}
