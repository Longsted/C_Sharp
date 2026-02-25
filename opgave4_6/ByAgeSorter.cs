namespace opgave4_6;

public class ByAgeSorter:IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        if (x.Age.CompareTo(y.Age) != 0)
        {
            return x.Age.CompareTo(y.Age);
        }

        return 0;
    }
}