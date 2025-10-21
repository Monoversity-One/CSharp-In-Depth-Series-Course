namespace _10.Object_OrientedProgramming._99.Examples._08_Game
{
    public class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }

        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed.");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }
    }
}
