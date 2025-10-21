namespace _10.Object_OrientedProgramming._99.Examples._03_Animals
{
    public class Dog : Animal
    {
        //bool property to check if the dog is happy
        public bool IsHappy { get; set; }

        //simple constructor where we pass the name and age to our base constructor
        public Dog(string name, int age) : base(name, age)
        {
            //all dogs are happy :)
            IsHappy = true;
        }

        //simple override of the virtual method Eat
        public override void Eat()
        {
            //to call the eat method from our base class we can use the keyword "base" and then call the method
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Wuuuf!");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
            else
            {
                Console.WriteLine($"{Name} doesn't want to play.");
            }
        }
    }
}
