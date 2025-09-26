using System;

namespace Lab5ZooAnimals.Animals.Mammals
{
    internal class AfricanElephant : Elephant
    {
        public int EarSize { get; set; }

        public AfricanElephant(string name, int age, int weight, bool isTame) : base(name, age, weight, isTame)
        {
            Species = "African Elephant";
            TrunkLength = 70;
            EarSize = 20;
        }

        public void FlapEars()
        {
            Console.WriteLine($"{Name} flaps its large ears ({EarSize} cm) to cool down!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the African Elephant trumpets loudly!");
        }
    }
}