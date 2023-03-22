using System;
using System.Collections.Generic;

public class Duck
{
    public string Name { get; set; }
    public int Weight { get; set; }
    public int NumWings { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Duck> ducks = new List<Duck>();

        while (true)
        {
            Console.WriteLine("1.Add a duck ");
            Console.WriteLine("2.Remove a duck ");
            Console.WriteLine("3.View all ducks");
            Console.WriteLine("4.Delete all ducks");
            Console.WriteLine("5.Sort ducks by weight");
            Console.WriteLine("6.Sort ducks by number of wings");
            Console.WriteLine("7.Exit");

            Console.Write("\nEnter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddDuck(ducks);
                    break;
                case 2:
                    RemoveDuck(ducks);
                   
                    break;
                case 3:
                    ViewAllDucks(ducks);
                    
                    break;
                case 4:
                    RemoveAllDucks(ducks);
                    break;
                case 5:
                    SortDucksByWeight(ducks);
                    break;
                case 6:
                    SortDucksByNumWings(ducks);
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void ViewAllDucks(List<Duck> ducks)
    {
        if (ducks.Count == 0)
        {
            Console.WriteLine("No ducks");
            return;
        }

        Console.WriteLine("{0,-10} {1,-10} {2,-10}", "Name", "Weight", "# Wings");
        foreach (Duck duck in ducks)
        {
            Console.WriteLine("{0,-10} {1,-10} {2,-10}", duck.Name, duck.Weight, duck.NumWings);
        }
    }

    static void AddDuck(List<Duck> ducks)
    {
        Duck duck = new Duck();

        Console.Write("Enter duck name: ");
        duck.Name = Console.ReadLine();

        Console.Write("Enter duck weight: ");
        duck.Weight = int.Parse(Console.ReadLine());

        Console.Write("Enter duck number of wings: ");
        duck.NumWings = int.Parse(Console.ReadLine());

        ducks.Add(duck);
        Console.WriteLine("Duck added");
    }

    static void RemoveDuck(List<Duck> ducks)
    {
        Console.Write("Enter duck name to remove: ");
        string name = Console.ReadLine();

        Duck duck = ducks.Find(d => d.Name == name);
        if (duck != null)
        {
            ducks.Remove(duck);
            Console.WriteLine("Duck removed");
        }
        else
        {
            Console.WriteLine("Duck not found");
        }
    }

    static void RemoveAllDucks(List<Duck> ducks)
    {
        ducks.Clear();
        Console.WriteLine("All ducks removed");
    }

    static void SortDucksByWeight(List<Duck> ducks)
    {
        ducks.Sort((d1, d2) => d1.Weight.CompareTo(d2.Weight));
        Console.WriteLine("Ducks sorted by weight");
    }

    static void SortDucksByNumWings(List<Duck> ducks)
    {
        ducks.Sort((d1, d2) => d1.NumWings.CompareTo(d2.NumWings));
        Console.WriteLine("Ducks sorted by number of wings");
    }
}
