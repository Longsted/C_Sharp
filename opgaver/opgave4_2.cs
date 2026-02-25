namespace opgaver;


public delegate void Warning();

public class Powerplant
{ 
    private Warning warning;

    public void SetWarning(Warning war)
    {
        warning += war;
    }

    public void Heatup()
    {
        Random rnd = new Random();
        int random = rnd.Next(0, 100);
        if (random > 50)
        {
            warning.Invoke();
        }
    }
}
