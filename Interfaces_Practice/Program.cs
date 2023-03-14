using System;

namespace Interfaces_Practice
{
    class Program
    {
        interface ILiveable
        {
            void Go();
            void Eat();
        }

        interface IGuardian : ILiveable
        {
            void Guard();
        }

        class Dog : IGuardian
        {
            public void Eat()
            {
                Console.WriteLine("Dog eats");
            }

            public void Go()
            {
                Console.WriteLine("Dog goes");
            }

            public void Guard()
            {
                Console.WriteLine("Dog guards");
            }
        }

        class Cat : ILiveable
        {
            public void Eat()
            {
                Console.WriteLine("Cat eats");
            }

            public void Go()
            {
                Console.WriteLine("Cat goes");
            }
        }

        static void Main(string[] args)
        {
            IGuardian guardDog = new Dog();
            ILiveable peacefulDog = new Dog();
            ILiveable peacefulCat = new Cat();

            guardDog.Go();
            guardDog.Guard();

            peacefulDog.Eat();

            peacefulCat.Go();
            peacefulCat.Eat();

            Console.ReadKey();
        }
    }
}
