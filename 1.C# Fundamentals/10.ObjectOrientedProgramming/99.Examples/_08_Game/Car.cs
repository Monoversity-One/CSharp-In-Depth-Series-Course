namespace _10.Object_OrientedProgramming._99.Examples._08_Game
{
    public class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }

        public List<IDestroyable> DestroyablesNearby;

        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");

            //destroy all the nearby objects
            foreach (var destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
