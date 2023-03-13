using System;

// Инвариатность - это ковариатность и контрвариатность
// одновременно относительно одного объекта.

namespace _005_Generics
{
    public abstract class Shape { }
    public class Circle : Shape { }

    // out предполагает ковариатность обобщения.
    public interface IContainer<out T>
    {
        T Figure { get; }
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
            get => this.figure;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Circle circle = new Circle();

            // Ковариатность обобщений.
            // Апкаст параметра типа.
            IContainer<Shape> container = new Container<Circle>(circle);

            Console.WriteLine(container.Figure.ToString());

            Console.ReadKey();
        }
    }
}
