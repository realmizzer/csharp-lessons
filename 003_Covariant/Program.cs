using System;

namespace _003_Covariant
{
    interface IAnimal
    {
        void Voice();
    }

    struct Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Woof!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };

            // Structures can't be covariant or contrvariant.
            //IAnimal[] animals = dogs;

            Console.WriteLine("Structures can't be covariant or contrvariant.");

            Console.ReadKey();
        }
    }
}
