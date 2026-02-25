using System;
using opgaver;

namespace opgaver
{
    public static class Calculate
    {
        public delegate int Operation(int a, int b);

        public static void CalculateAndDisplay(int a, int b, Operation operation)
        {
            Console.WriteLine(operation(a, b));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Opgave1.Lang("er denne over 5?"));
        Calculate.CalculateAndDisplay(5, 3, Calculate.Add);
        Calculate.CalculateAndDisplay(5, 3, Calculate.Multiply);

       static void warningToConsole()
        {
            Console.WriteLine("Advarsel");
        }

        static void anotherWarningToConsole()
        {
            Console.WriteLine("Advarsel2");
        }
       Powerplant powerplant = new Powerplant();
       powerplant.SetWarning(warningToConsole);
       powerplant.SetWarning(anotherWarningToConsole);
       powerplant.Heatup();
    }
}



   