namespace _10.Object_OrientedProgramming._99.Examples._08_Game
{
    public class Vehicle
    {
        public float Speed { get; set; }

        public string Color { get; set; }

        public Vehicle()
        {
            Speed = 200;
            Color = "Red";
        }

        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
