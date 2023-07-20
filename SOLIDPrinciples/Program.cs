using System;
using System.Collections.Generic;

namespace SOLIDPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarnivoreAnimals carnivoreAnimals = new CarnivoreAnimals();
            HerbivoreAnimals herbivoreAnimals = new HerbivoreAnimals();

            carnivoreAnimals.FeedCarnivore();
            herbivoreAnimals.FeedHerbivore();
        }
    }
}
public interface IFeedCarnivore
{
    void FeedCarnivore();
}

public interface IFeedHerbivore
{
    void FeedHerbivore();
}

public class CarnivoreAnimals : IFeedCarnivore
{
    public void FeedCarnivore()
    {
        Console.WriteLine("Carnivore animals are being fed with meat");
    }
}

public class HerbivoreAnimals : IFeedHerbivore
{
    public void FeedHerbivore()
    {
        Console.WriteLine("Herbivore animals are being fed with grass");
    }
}
