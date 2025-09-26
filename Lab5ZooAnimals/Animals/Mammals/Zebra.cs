using System;

namespace Lab5ZooAnimals.Animals.Mammals
{
    internal class Zebra : Animal
    {
        public int StripeCount { get; set; }

        public Zebra(string name, int age, int weight, bool isTame) : base(name, "Zebra", age, weight, false, AnimalType.Mammal, isTame)
        {
            StripeCount = 2;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Zebra neighs!");
        }

        public void Run()
        {
            Console.WriteLine($"{Name} the Zebra is running!");
        }
    }
}
