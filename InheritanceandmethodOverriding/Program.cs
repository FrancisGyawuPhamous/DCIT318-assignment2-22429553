using System;

namespace InheritanceAndOverriding
{
    // Base class
    class Animal
    {
        // Virtual method so derived classes can override it
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class: Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class: Cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 1: Inheritance and Method Overriding ===\n");

            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            Console.Write("Animal instance -> ");
            genericAnimal.MakeSound();

            Console.Write("Dog instance    -> ");
            dog.MakeSound();

            Console.Write("Cat instance    -> ");
            cat.MakeSound();
        }
    }
}

