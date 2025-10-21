namespace _10.Object_OrientedProgramming._07.Polymorphism
{
    public class _06_ShapesExample
    {
        public virtual void Draw()
        {
            Console.WriteLine("This is a simple shape!");
        }
    }
    public class Circle2 : _06_ShapesExample
    {
        public override void Draw()
        {
            Console.WriteLine("This is a simple circle.");
        }
    }
    public class Square2 : _06_ShapesExample
    {
        public override void Draw()
        {
            Console.WriteLine("This is a simple square.");
        }
    }

    public class Rectangle2 : _06_ShapesExample
    {
        public new void Draw()
        {
            Console.WriteLine("This is a simple rectangle.");
        }
    }

}
