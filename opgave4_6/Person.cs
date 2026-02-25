namespace opgave4_6;

public class Person //: IComparable<Person>
{
    public int Age { get;private set; }
    public int Weight { get;private set; }
    public string Name { get;private set; }

    public Person(int age, int weight, string name)
    {
        Age = age;
        Weight = weight;
        Name = name;
    }

    //en sorteringsmetode
    // public int CompareTo(Person? other) =>
    //     this.Age.CompareTo(other.Age);

}