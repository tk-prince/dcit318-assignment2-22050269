using System;

namespace InterfaceDemo
{
    // Interface — a contract: any implementing class must provide Move()
    public interface IMovable
    {
        void Move();
    }

    // Car implements the IMovable interface
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Bicycle implements the IMovable interface
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Interfaces Demo ===\n");

            // Create instances of Car and Bicycle
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            // Call Move() on each instance
            car.Move();       // Output: Car is moving
            bicycle.Move();   // Output: Bicycle is moving

            // Bonus: an interface reference can hold ANY implementing type
            Console.WriteLine("\n--- Polymorphism with an IMovable[] array ---");
            IMovable[] vehicles = { new Car(), new Bicycle() };
            foreach (IMovable vehicle in vehicles)
            {
                vehicle.Move();
            }
        }
    }
}
