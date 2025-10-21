namespace _14.Structs
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public double Length() => Math.Sqrt(X * X + Y * Y);
        public override string ToString() => $"({X},{Y})";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(3, 4); // value type
            var p2 = p1;               // copy
            p2.X = 10;

            Console.WriteLine($"p1 = {p1}, len={p1.Length():F1}");
            Console.WriteLine($"p2 = {p2}, len={p2.Length():F1}");
        }
    }
}
