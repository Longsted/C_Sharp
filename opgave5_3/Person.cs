namespace opgave5_3;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }
    public int Score { get; set; }

    public bool Accepted { get; set; }

    
    public Person(string data) {
// Name, Age, Weight, Score
        var L = data.Split(';');
        Name = L[0];
        Age = int.Parse(L[1]);
        Weight = int.Parse(L[2]);
        Score = int.Parse(L[3]);
        Accepted = false; //denne parameter bliver ikke indlæst, men skal bruges senere.
    }



    public override string ToString()
    {
        return $" navn {Name} alder {Age} vægt {Weight} score {Score} accepted {Accepted} ";
    }


    

    public static List<Person> ReadCSVFile(string filename)
        {
            List<Person> list = new List<Person>();
            using (var file = new StreamReader(filename))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var p = new Person(line);
                    list.Add(p);
//Console.WriteLine(p);
                }
            }

            return list;
        }
    
    }

public static class PersonExtensions
{
    public static void SetAccepted(this List<Person> first, Predicate<Person> predicate)
    {
        first.FindAll(predicate).ForEach(p => p.Accepted = true);
    }

    public static void Reset(this List<Person> first)
    {
        first.ForEach(p => p.Accepted = false);
    }
}

