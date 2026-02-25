using System;
using System.Diagnostics;
using opgave5_3;

class Program
{
    static List<Person> people1;

    static void Main(string[] args)
    {
        Exercise1();
        var scoreUnder2 = people1.FindAll(i => i.Score < 2);
        var equalScore = people1.FindAll(i => i.Score % 2 == 0);
        var equalScoreANdWeightOver60 = people1.FindAll(i => i.Weight > 60 && i.Score % 2 == 0);
        var weightEqualEvenBy3Division = people1.FindAll(i => i.Weight % 3 == 0 && i.Weight %2 == 0);
        
        // Console.WriteLine("score under 2 \n");
        // scoreUnder2.ForEach(i => Console.WriteLine(i.ToString()));
        // Console.WriteLine("\n equal score \n");
        // equalScore.ForEach(i => Console.WriteLine(i.ToString()));
        // Console.WriteLine("\n equal score og vægt over 60 \n");
        // equalScoreANdWeightOver60.ForEach(i => Console.WriteLine(i.ToString()));
        // Console.WriteLine("\n vægt lige divideret med 3 \n");
        // weightEqualEvenBy3Division.ForEach(i => Console.WriteLine(i.ToString()));
        //

        //opgave 5.4 using findIndex
        /*documentation for findIndex her :
         https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.findindex?view=net-5.0
         (alle queries med FindIndex skal du skrive som lambda udtryk - nemmest)
        1. Brug FindIndex metoden på listen til at finde index på den første person med en
        score på præcis 3.
        2. Brug FindIndex til at finde index på den første person under 10 år, som har en
        score på 3.
        3. Hvor mange personer er der under 10 år som har en score på 3? (Hint: Her skal
        du bruge FindAll…)
        4. Brug FindIndex til at finde index på den første personer under 8 år, med en
        score på 3. Bemærk return value her – hvad betyder dette?
         */
        var indexFirstPersonScorePrecisely3 = people1.FindIndex(i => i.Score % 3 == 0);
        Console.WriteLine(indexFirstPersonScorePrecisely3);
        var indexUnderAge10ScoreOn3 = people1.FindIndex(i => i.Age < 10 && i.Score < 3);
        Console.WriteLine(indexUnderAge10ScoreOn3);
        var howManyUnder10ScoreOn3 = people1.FindAll(i => i.Age < 10 && i.Score < 3).Count;
        Console.WriteLine(howManyUnder10ScoreOn3);
        var firstPersonUnder8ScoreOn3 = people1.FindIndex(i => i.Age < 8 && i.Score == 3);
        Console.WriteLine(firstPersonUnder8ScoreOn3); //returnerer -1 da denne ikke findes. Læs dokumentation
        
        //opgave 5.6 predicates og extension methods
        
        // people1.SetAccepted(p => p.Score >= 6 && p.Age <= 40);
        // var accepted = people1.FindAll(i => i.Accepted == true);
        // accepted.ForEach(i => Console.WriteLine(i));
        
        //opgave 5.7 LINQ
        
        /*
         * Brug LINQ til at sortere listen af personer efter Score og Age. Sortér efter både stigende
            og faldende orden. Bemærk, at nu skal vi ikke til at implementere et interface eller
            noget…så koden burde være ”pænere”. Prøv at lave det med Query Expression syntaxen
            – det er nok det nemmeste at overskue. Se slides for eksempler på syntaxen.
         */
        IEnumerable<Person> sorteretEfterScoreOgAge = from i in people1
            orderby i.Score, i.Age
            select i;

        IEnumerable<Person> omvendt = from i in people1 // kan også bare bruge reverse() til at lave denne
            orderby i.Score descending, i.Age descending
            select i;
        
        // foreach (var person in omvendt)
        // {
        //     Console.WriteLine(person + " ");
        //
        // }
        
        // foreach (var person in sorteretEfterScoreOgAge)
        // {
        //     Console.WriteLine(person + " ");
        // }
        
        //øvelse 5.8
        /*
         * Skriv forskellige LINQ statements til at lave de følgende ting:
        1. Returner alle two-digit integers sorteret i ascending order.
        2. Returner alle two-digit integers sorteret i descending order.
        3. Som i delopgave 1), men I stedet for integers, så skal der returneres strings dvs.
        f.eks. ”20”, ”31”, ”34”, etc.
        4. Som i delopgave 2), men skal returnere string af typen “20 even”, “31 uneven”,
        etc…
        Hint: til delopgave 4 her, får du nok brug for en conditional operator, da return værdier jo
        skal afhænge af om det er et lige eller et ulige tal.
        https://docs.microsoft.com/en-us/dotnet/csharp%C3%A6/language-reference/operators/conditional-operator%C2%A0(Links%20til%20en%20ekstern%20webside.)
         */
        
        int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };
        IEnumerable<int> ascendingTwoDigit = from i in numbers
            where i < 100
            orderby i ascending
                select i;
            
        IEnumerable<int> descendingTwoDigit = from i in numbers
                                                where i < 100
                                                    orderby i descending 
                                                    select i;

        IEnumerable<string> delopgave1MedStrings = from i in numbers
            where i < 100
            orderby i
            select i.ToString() ;

        IEnumerable<string> delopgave2MedEvenUneven = from i in numbers

            where i < 100
            orderby i
            select
             i.ToString() + " " + ( i % 2 == 0 ? "even" : "uneven");
                
            

        foreach (var se in delopgave2MedEvenUneven)
        {
            Console.WriteLine(se);
        }

        //opgave 5.9 extension ligger i person klassen
        people1.Reset();
    }

    static void Exercise1()
    {
        try
        {
            people1 = Person.ReadCSVFile(@"C:\Users\niels\Desktop\C# & .NET\data1.csv");
        }
        catch (Exception ex)
        {
            Console.WriteLine("EXCEPTION: " + ex.Message);
        }
    }
}