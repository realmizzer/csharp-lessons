using System;

namespace _008_Delegates
{
    class Animal { }
    class Cat : Animal { }

    internal class Program
    {
        delegate T MyDelegate<out T>();

        public static Cat CatCreator()
        {
            return new Cat();
        }

        static void Main(string[] args)
        {
            MyDelegate<Cat> delegateCat = new MyDelegate<Cat>(CatCreator);

            // Ковариатность обобщений.
            MyDelegate<Animal> delegateAnimal = delegateCat;

            // Cat -> Animal "Я стараюсь заботиться о тебе.".
            Animal animal = delegateAnimal.Invoke();

            Console.WriteLine(animal.GetType().Name);

            Console.ReadKey();

        }
    }
}
