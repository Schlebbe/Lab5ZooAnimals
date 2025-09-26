using System;

namespace Lab5ZooAnimals.Plants.Trees
{
    internal class OakTree : Tree
    {
        public int AcornCount { get; set; }

        public OakTree(string name, int age, double height, bool isFlowering, bool hasFruit) : base(name, age, height, isFlowering, hasFruit)
        {
            Species = "Oak";
            AcornCount = 83;
        }

        public void DropAcorns()
        {
            Console.WriteLine($"{Name} the Oak drops {AcornCount} acorns.");
        }

        public override void Grow(double amount)
        {
            Height += amount;
            Console.WriteLine($"{Name} the Oak tree grows {amount} cm and is strong and tall!");
        }
    }
}