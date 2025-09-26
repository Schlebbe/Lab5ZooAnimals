using System;

namespace Lab5ZooAnimals.Animals.Mammals
{
    internal class Lion : Animal
    {
        public int ManeLength { get; set; }

        public Lion(string name, int age, int weight, bool isTame) : base(name, "Lion", age, weight, true, AnimalType.Mammal, isTame)
        {
            ManeLength = 20;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Lion roars!");
        }

        public void Hunt()
        {
            Console.WriteLine($"{Name} the Lion is hunting!");
        }
    }
}
