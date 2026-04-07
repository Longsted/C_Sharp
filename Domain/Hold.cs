namespace Domain;

public class Hold
{
    public int Id{get;set;}
    public string Navn { get; set; }
    public DateTime StudieStart { get; set; }
    public DateTime StudieEnd { get; set; }
    public List<Studerende> Studerendes { get; set; } = new();

    public Hold(int id, string navn, DateTime studieStart, DateTime studieEnd)
    {
        Id = id;
        this.Navn = navn;
        this.StudieStart = studieStart;
        this.StudieEnd = studieEnd;
    }

    public Hold()
    {
    }

    public void AddStuderende(Studerende studerende)
    {
        if (!Studerendes.Contains(studerende))
        {
            Studerendes.Add(studerende);
        }
    }

    public void RemoveStuderende(Studerende studerende)
    {
        if (Studerendes.Contains(studerende))
        {
            Studerendes.Remove(studerende);
        }
    }
}