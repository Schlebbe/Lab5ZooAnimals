using System;

namespace Lab5ZooAnimals.Animals.Mammals
{
    internal class AsianElephant : Elephant
    {
        public bool HasSmallerEars { get; set; }

        public AsianElephant(string name, int age, int weight, bool isTame) : base(name, age, weight, isTame)
        {
            Species = "Asian Elephant";
            TrunkLength = 50;
            HasSmallerEars = true;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Asian Elephant trumpets softly!");
        }

        public void Paint()
        {
            Console.WriteLine($"{Name} the Asian Elephant is painting with its trunk!");
        }
    }
}