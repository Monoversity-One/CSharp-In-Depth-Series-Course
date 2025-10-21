namespace _10.Object_OrientedProgramming._99.Examples._03_Animals
{
    public class Animal
    {
        //name property
        public string Name { get; set; }

        //age property
        public int Age { get; set; }

        //is hungry boolean to check whether the animal is hungry
        public bool IsHungry { get; set; }

        //simple constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;

            //in our case all our animals are hungry by default!
            IsHungry = true;
        }

        //an empty virtual method MakeSound for other classes to override
        public virtual void MakeSound()
        {

        }

        //a virtual method called Eat which sub classes can override
        public virtual void Eat()
        {
            //check if animal is hungry
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating.");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry.");
            }
        }

        //virtual method Play
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }
    }
}
