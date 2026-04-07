namespace EntityFrameWork;

public class Bil
{
    public int BilId{get;set;}
    public string Name{get;set;}
    public int Weight {get;set;}
    
    public int EjerId { get; set; }
    public Ejer Ejer { get; set; }


    public List<Reservedel> Reservedele { get; set; } = new();
    public Bil(string name, int weight, Ejer ejer)
    {
        Name = name;
        Weight = weight;
        Ejer = ejer;
    }
    

    public Bil()
    {
    }
}