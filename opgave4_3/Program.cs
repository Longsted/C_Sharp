using System;

namespace opgave4_3
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Del a: kald den almindelige factorial
            Console.WriteLine(Factorial(5)); // 120

            // Del b: extension method
            Console.WriteLine(4.Factorial()); // 24
            
            //del 4. a kald almindelig Power
            Console.WriteLine(Power(2,2)); //4
            
            // del 4. a kald power extension method
            Console.WriteLine(2.Power(2)); //4
        }

        // Del a
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
        //opgave 4.4 a
        public static int Power(int n, int p)
        {
            int result = 1;
            if (p >= 0)
            {
               
                for (int i = 0; i < p; i++)
                {
                    result *= n;
                }
            }
            else
            {
                throw new ArgumentException("Negative power!");
            }
            return result;
        }
    }

// Del b: extension method i separat static class
    public static class IntExtensions
    {
        public static int Factorial(this int n)
        {
            if(n < 0 ) throw new ArgumentException("Negative number!");
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        public static int Power(this int n, int p)
        {
            if (p < 0) throw new ArgumentException("Negative power!");
            if(p == 0) return 1;
            return n * Power(n, p - 1);
        }
    }
}
