namespace EntityFrameWork;

public class Ejer
{
    public int EjerId { get; set; }
    public string ForNavn{get;set;}
    public string SurName{get;set;}
    public List<Bil> Biler { get; set; } = new();

    public Ejer()
    {
        
    }

    public Ejer(string forNavn, string surName)
    {
        ForNavn = forNavn;
        SurName = surName;
    }
}