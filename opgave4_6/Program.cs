using System;
using System.Collections.Generic;
using opgave4_6;

static class Program
{
    public static void Main(string[] args)
    {
        List<Person> personer = new List<Person>
        {
            new Person(25, 70, "Bob"),
            new Person(75, 90, "John"),
            new Person(30, 105, "IB")
        };

        //sorter med lambda udtryk
        personer.Sort((a,b)=> a.Age.CompareTo(b.Age));
        
        // Sorter efter alder
        // personer.Sort(new ByAgeSorter());
        // Console.WriteLine("Sorter efter alder:");
        // foreach (var person in personer)
        //     Console.WriteLine(person.Name);

        Console.WriteLine();

        // Sorter efter vægt
        personer.Sort(new ByWeightSorter());
        Console.WriteLine("Sorter efter vægt:");
        foreach (var person in personer)
            Console.WriteLine(person.Name);

        Console.WriteLine();

        // Sorter efter navn
        personer.Sort(new ByNameSorter());
        Console.WriteLine("Sorter efter navn:");
        foreach (var person in personer)
            Console.WriteLine(person.Name);
    }
}