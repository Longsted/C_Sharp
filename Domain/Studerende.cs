namespace Domain;

public class Studerende
{
    
    public int Id{get;set;}
    public string Navn { get; set; }
    public DateTime StudieStart { get; set; }
    public int Alder{get;set;}
    public studieType StudieType { get; set; }
    public int? HoldId { get; set; }
    public Hold? Hold{get;set;}

    public Studerende(string navn, DateTime studieStart, int alder, studieType studieType)
    {
        this.Navn = navn;
        this.StudieStart = studieStart;
        this.Alder = alder;
        this.StudieType = studieType;
    }

    public Studerende()
    {
    }
}

