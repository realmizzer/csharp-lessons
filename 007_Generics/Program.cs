using System;

namespace _007_Delegates
{
    class Animal { }
    class Cat : Animal { }

    internal class Program
    {
        delegate void MyDelegate<in T>(T a);

        public static void CatCreator(Animal animal)
        {
            Console.WriteLine(animal.GetType().Name);
        }

        static void Main(string[] args)
        {
            MyDelegate<Animal> delegateAnimal = new MyDelegate<Animal>(CatCreator);

            // Контрвариатность обобщений.
            // Cat -> Animal "Я не буду в тебя приводиться.".
            MyDelegate<Cat> delegateCat = delegateAnimal;

            delegateAnimal(new Animal());
            delegateCat(new Cat());

            // delegateCat(new Animal());

            Console.ReadKey();

        }
    }
}
