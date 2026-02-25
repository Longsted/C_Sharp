namespace musicstore.Models;

public class Track
{
    private string title;
    
    public string Title { get => title; set => title = value; }
    
    private string composer;
    public string Composer { get => composer; set => composer = value; }
    private string length;
    public string Length { get => length; set => length = value; }

    public Track(string title, string composer, string length)
    {
        this.title = title;
        this.composer = composer;
        this.length = length;
    }

    public override string ToString()
    {
        return "Title: " + title + ", Composer: " + composer + ", Length: " + length;
    }
}