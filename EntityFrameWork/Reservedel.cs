namespace EntityFrameWork;

public class Reservedel
{
    public int ReservedelId { get; set; }
    public string Mærke{get;set;}
    public List<Bil> Biler { get; set; } = new();
    public string Name {get;set;}


    public Reservedel()
    {
    }
    
    
}