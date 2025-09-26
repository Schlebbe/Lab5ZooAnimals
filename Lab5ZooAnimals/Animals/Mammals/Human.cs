using System;

namespace Lab5ZooAnimals.Animals.Mammals
{
    internal class Human : Animal
    {
        public string Occupation { get; set; }

        public Human(string name, int age, int weight, bool isTame) : base(name, "Human", age, weight, true, AnimalType.Mammal, isTame)
        {
            Occupation = "Software Developer";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Human says hello!");
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Occupation}.");
        }
    }
}