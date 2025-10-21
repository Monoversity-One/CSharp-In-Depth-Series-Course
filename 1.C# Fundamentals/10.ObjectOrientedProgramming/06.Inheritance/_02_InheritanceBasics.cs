namespace _10.Object_OrientedProgramming._06.Inheritance
{
    // Base class
    class Animal2
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal2(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }

    // Derived class
    class Dog : Animal2
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name}, the {Breed}, is barking.");
        }
    }
}
