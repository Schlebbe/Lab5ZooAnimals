using System;

namespace Lab5ZooAnimals.Plants.Flowers
{
    internal class Flower : Plant
    {
        public string Color { get; set; }

        public Flower(string name, int age, double height, string color) : base(name, "Flower", age, height, true, PlantType.Flower)
        {
            Color = color;
        }

        public override void Grow(double amount)
        {
            Height += amount;
            Console.WriteLine($"{Name} the Flower extends by {amount} cm.");
        }

        public void Bloom()
        {
            Console.WriteLine($"{Name} the Flower is blooming beautifully!");
        }
    }
}