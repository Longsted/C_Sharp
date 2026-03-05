namespace opgave.Models;

public class ParkingTicketMachine
{
    private int minutesPrKr;
    private int[] coinsToInsert;
    
    private DateTime timeNow;

    public int[] CoinsToInsert
    {
        get => coinsToInsert;
    }

    public DateTime TimeNow { 
        get => timeNow;
        set => timeNow = value;
}

    public DateTime PaidUntil
    {
        get => timeNow.AddMinutes(minutesPrKr * AmountInserted);
    }

    public int AmountInserted
    {
        get;
        set;
    }

    public ParkingTicketMachine()
    {
        this.minutesPrKr = 3;
        this.timeNow = DateTime.Now;
        // this.AmountInserted = 0;
        this.coinsToInsert = new[] { 1, 2, 5, 10, 20 };
    }

    public void InsertCoin(int kr)
    {
        AmountInserted += kr;
        
    }
}