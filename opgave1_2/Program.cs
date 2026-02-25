Console.WriteLine("Hello, World!");

List<int> talListe = new List<int>(){1,2,45,4,34,6,7,16,20,14};

//opgave 1
var even = talListe.FindAll(i => i%2==0);

// even.ForEach(i => Console.WriteLine(i));

//opgave lav en søgning efter det sidste tal over 15
var lastNumberOver15 = talListe.FindLast(i => i > 15);
// Console.WriteLine(lastNumberOver15);

//lav en søgning efter index på det sidste tal over 15
var indexLastNumberoVer15 =  talListe.FindLastIndex(i => i > 15);
// Console.WriteLine(indexLastNumberoVer15);

//opgave 5.2 LINQ
//alle lige ints
IEnumerable<int>allEquals = talListe.Where(i => i%2==0);
foreach (int i in allEquals)
{
    Console.WriteLine(i);
}
var sorted = allEquals.OrderBy(i=>i);
Console.WriteLine("\nSorteret");
foreach (var item in sorted)
{
    Console.WriteLine(item);
}

//alle ints med præcis to cifre (brug tostring og længden)
IEnumerable<int>two = talListe.Where(i=> i.ToString().Length == 2);
// two.ToList().ForEach(t => Console.WriteLine(t));

