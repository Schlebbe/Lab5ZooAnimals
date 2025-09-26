using System;

namespace Lab5ZooAnimals.Plants.Trees
{
    internal class Tree : Plant
    {
        public bool HasFruit { get; set; }

        public Tree(string name, int age, double height, bool isFlowering, bool hasFruit) : base(name, "Tree", age, height, isFlowering, PlantType.Tree)
        {
            HasFruit = hasFruit;
        }

        public override void Grow(double amount)
        {
            Height += amount;
            Console.WriteLine($"{Name} the Tree stretches its branches by {amount} cm.");
        }

        public void ShedLeaves()
        {
            Console.WriteLine($"{Name} the Tree is shedding its leaves.");
        }
    }
}