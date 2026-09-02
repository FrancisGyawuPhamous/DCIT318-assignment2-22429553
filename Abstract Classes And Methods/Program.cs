using System;

namespace AbstractClasses
{
    // Abstract base class
    abstract class Shape
    {
        // Abstract method - no implementation here, must be implemented by derived classes
        public abstract double GetArea();
    }

    // Derived class: Circle
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Derived class: Rectangle
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 2: Abstract Classes and Methods ===\n");

            Shape circle = new Circle(5.0);
            Shape rectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine($"Circle (radius = 5.0) area:      {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle (4.0 x 6.0) area:       {rectangle.GetArea():F2}");
        }
    }
}
