using System;

namespace Lab5ZooAnimals.Plants.Trees
{
    internal class PineTree : Tree
    {
        public int ConeCount { get; set; }

        public PineTree(string name, int age, double height, bool isFlowering, bool hasFruit) : base(name, age, height, isFlowering, hasFruit)
        {
            Species = "Pine";
            ConeCount = 23;
        }

        public void DropCones()
        {
            Console.WriteLine($"{Name} the Pine drops {ConeCount} cones.");
        }

        public override void Grow(double amount)
        {
            Height += amount;
            Console.WriteLine($"{Name} the Pine tree grows {amount} cm and stands tall and evergreen!");
        }
    }
}