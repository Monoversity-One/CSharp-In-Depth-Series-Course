namespace _10.Object_OrientedProgramming._07.Polymorphism
{
    abstract class Shape
    {
        // Abstract method for calculating area
        public abstract double CalculateArea();

        // Virtual method for displaying shape information
        public virtual void DisplayInfo()
        {
            Console.WriteLine("This is a shape.");
        }
    }



    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Overriding the CalculateArea method
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Overriding the DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine($"This is a circle with radius {Radius}");
        }
    }



    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Overriding the CalculateArea method
        public override double CalculateArea()
        {
            return Width * Height;
        }

        // Overriding the DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine($"This is a rectangle with width {Width} and height {Height}");
        }
    }



    class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        // Overriding the CalculateArea method
        public override double CalculateArea()
        {
            return 0.5 * BaseLength * Height;
        }

        // Overriding the DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine($"This is a triangle with base {BaseLength} and height {Height}");
        }
    }
}
