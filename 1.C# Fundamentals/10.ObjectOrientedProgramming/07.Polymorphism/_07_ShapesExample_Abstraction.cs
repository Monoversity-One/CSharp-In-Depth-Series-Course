namespace _10.Object_OrientedProgramming._07.Polymorphism
{
    public abstract class _07_ShapesExample_Abstraction
    {
        public abstract void Draw();
        public void SayHi()
        {
            Console.WriteLine("Hello from the abstract class");
        }
    }

    public class Lines : _07_ShapesExample_Abstraction
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a line!");
        }
    }
}
