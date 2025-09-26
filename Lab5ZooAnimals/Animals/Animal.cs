using System;

namespace Lab5ZooAnimals.Animals
{
    internal enum AnimalType
    {
        Mammal,
        Reptile,
        Bird,
        Amphibian,
        Fish,
        Insect
    }

    internal abstract class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public bool IsCarnivore { get; set; }
        public AnimalType Type { get; set; }
        public bool IsTame { get; set; }

        public Animal(string name, string species, int age, int weight, bool isCarnivore, AnimalType type, bool isTame)
        {
            Name = name;
            Species = species;
            Age = age;
            Weight = weight;
            IsCarnivore = isCarnivore;
            Type = type;
            IsTame = isTame;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} the {Species} makes a sound!");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Name} the {Species} eats {food}.");
        }

        public void Sleep(int hours)
        {
            Console.WriteLine($"{Name} the {Species} sleeps for {hours} hours.");
        }
    }
}
