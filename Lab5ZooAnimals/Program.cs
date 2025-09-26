using Lab5ZooAnimals.Animals.Mammals;
using Lab5ZooAnimals.Plants.Flowers;
using Lab5ZooAnimals.Plants.Trees;

namespace Lab5ZooAnimals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant = new Elephant("Ella", 10, 1200, true);
            elephant.MakeSound();

            AsianElephant asianElephant = new AsianElephant("Asha", 8, 900, false);
            asianElephant.MakeSound();

            AfricanElephant africanElephant = new AfricanElephant("Afi", 12, 1300, false);
            africanElephant.MakeSound();

            Lion lion = new Lion("Leo", 15, 80, false);
            lion.MakeSound();

            Zebra zebra = new Zebra("Zane", 3, 350, false);
            zebra.MakeSound();

            Human human = new Human("Alex", 30, 75, true);
            human.MakeSound();

            Flower flower = new Flower("Kerstin", 5, 10, "Red");
            flower.Grow(5);

            Tree tree = new Tree("Kalle", 20, 170, false, true);
            tree.Grow(20);

            OakTree oakTree = new OakTree("Åke", 25, 200, false, true);
            oakTree.Grow(15);

            PineTree pineTree = new PineTree("Pia", 30, 250, false, true);
            pineTree.Grow(10);
        }
    }
}
