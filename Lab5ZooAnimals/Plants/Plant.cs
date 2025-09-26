using System;

namespace Lab5ZooAnimals.Plants
{
    internal enum PlantType
    {
        Tree,
        Flower,
        Shrub,
        Grass,
        Fern,
        Succulent
    }

    internal abstract class Plant
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public bool IsFlowering { get; set; }
        public PlantType Type { get; set; }

        public Plant(string name, string species, int age, double height, bool isFlowering, PlantType type)
        {
            Name = name;
            Species = species;
            Age = age;
            Height = height;
            IsFlowering = isFlowering;
            Type = type;
        }

        public virtual void Grow(double amount)
        {
            Height += amount;
            Console.WriteLine($"{Name} the {Species} grows by {amount} cm.");
        }
    }
}