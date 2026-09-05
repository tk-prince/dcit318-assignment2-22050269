using System;

namespace AbstractClassDemo
{
    // Abstract class — cannot be instantiated directly
    public abstract class Shape
    {
        // Abstract method — no body; derived classes MUST implement it
        public abstract double GetArea();
    }

    // Derived class: Circle implements GetArea()
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class: Rectangle implements GetArea()
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Classes and Methods Demo ===\n");

            // Shape shape = new Shape();  // ❌ Compile error: cannot create
            //                                an instance of an abstract class

            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine($"Circle (radius = {circle.Radius}):");
            Console.WriteLine($"  Area = {circle.GetArea():F2}\n");

            Console.WriteLine($"Rectangle ({rectangle.Width} x {rectangle.Height}):");
            Console.WriteLine($"  Area = {rectangle.GetArea():F2}");

            // Bonus: treat both shapes polymorphically via the abstract base
            Console.WriteLine("\n--- Polymorphism with a Shape[] array ---");
            Shape[] shapes = { circle, rectangle, new Circle(1.5), new Rectangle(2, 3) };
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name,-10} area: {shape.GetArea():F2}");
            }
        }
    }
}
