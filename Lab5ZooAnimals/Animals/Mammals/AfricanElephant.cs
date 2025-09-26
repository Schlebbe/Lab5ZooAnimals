using System;

namespace Lab5ZooAnimals.Animals.Mammals
{
    internal class AfricanElephant : Elephant
    {
        public AfricanElephant(string name, int age, int weight, bool isTame) : base(name, age, weight, isTame)
        {
            Species = "African Elephant";
            TrunkLength = 70;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the African Elephant trumpets loudly!");
        }
    }
}