using System;

namespace _004_Generics
{
    public abstract class Shape { }
    public class Circle : Shape { }

    public interface IContainer<T>
    {
        T Figure { get; set; }
    }

    public class Container<T> : IContainer<T>
    {
        // T будет классом Circle.
        public T Figure { get; set; }

        public Container(T figure)
        {
            Figure = figure;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Circle circle = new Circle();

            IContainer<Shape> container = new Container<Shape>(circle);

            Console.WriteLine(container.Figure.ToString());

            Console.ReadKey();
        }
    }
}
