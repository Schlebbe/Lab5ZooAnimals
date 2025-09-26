using System;

namespace Lab5ZooAnimals.Animals.Mammals
{
    internal class Elephant : Animal
    {
        public int TrunkLength { get; set; }

        public Elephant(string name, int age, int weight, bool isTame) : base(name, "Elephant", age, weight, false, AnimalType.Mammal, isTame)
        {
            TrunkLength = 60;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Elephant trumpets!");
        }

        public void SprayWater()
        {
            Console.WriteLine($"{Name} the Elephant sprays water with its trunk!");
        }
    }
}
