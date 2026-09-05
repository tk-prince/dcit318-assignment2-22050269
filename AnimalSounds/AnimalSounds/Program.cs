using System;

namespace InheritanceDemo
{
    // Base class
    public class Animal
    {
        // 'virtual' allows derived classes to override this method
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class: Dog inherits from Animal
    public class Dog : Animal
    {
        // 'override' replaces the base class implementation
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class: Cat inherits from Animal
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance and Method Overriding Demo ===\n");

            // Create instances of each class
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call MakeSound() on each instance
            Console.Write("Animal: ");
            animal.MakeSound();   // Output: Some generic sound

            Console.Write("Dog:    ");
            dog.MakeSound();      // Output: Bark

            Console.Write("Cat:    ");
            cat.MakeSound();      // Output: Meow

            // Bonus: polymorphism in action — a base-class reference
            // calls the correct overridden method at runtime
            Console.WriteLine("\n--- Polymorphism with an Animal[] array ---");
            Animal[] animals = { new Animal(), new Dog(), new Cat() };
            foreach (Animal a in animals)
            {
                a.MakeSound();
            }
        }
    }
}
