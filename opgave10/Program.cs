
List<int>hundredRandomNumbers = new List<int>();

/*Lav en liste af 100 random integers. Så brug LINQ til de følgende delopgaver:
1. a) Find antallet af ulige tal I listen.
2. b) Find antallet af unikke tal I listen (f.eks. skal 3,3,5 give 2 )
3. c) Find de tre første ulige tal.
4. d) Find alle unikke ulige tal.*/
Random rnd = new Random();
for (int i = 0; i < 100; i++)
{
    
    hundredRandomNumbers.Add(rnd.Next(1,30));
}
// hundredRandomNumbers.ForEach(i => Console.WriteLine(i));

var antalUlige = (from i in hundredRandomNumbers
    where i % 2 == 1
    select i).Count();

int unikke = hundredRandomNumbers.Distinct().Count();
// Console.WriteLine(unikke);

IEnumerable<int> treFørste = (from i in hundredRandomNumbers
    where i % 2 == 1
    
    select i).Take(3);
    
    foreach (var i in treFørste)
    {
        // Console.WriteLine(i);
    }

    IEnumerable<int> alleUnikke = (from i in hundredRandomNumbers
        select i).Distinct();
    foreach (var i in alleUnikke)
    {
        Console.WriteLine(i);
    }
    int virkerMetode = alleUnikke.Count();
    Console.WriteLine(virkerMetode);