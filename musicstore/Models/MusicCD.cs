namespace musicstore.Models;

public class MusicCD:Product
{
    
    
    private string artist;

    public string Artist
    {
        get { return artist; }
        set { artist = value; }
    }
    
    private string label;

    public string Label
    {
        get => label;
        set => label = value;
    }
    private short released;

    public short Released
    {
        get => released;
        set => released = value;
    }
    private List<string> tracks = new List<string>();

    public List<string> Tracks
    {
        get => tracks;
    }

    private List<Track> tracklist = new List<Track>();

    public List<Track> TrackList
    {
        get => tracklist;
    }

  
    
    public void AddTrack(string track)
    {
        tracks.Add(track);
    }
    public void AddTrack(Track track)
    {
        tracklist.Add(track);
    }

    public MusicCD(string title, decimal price, string imageUrl, string artist, string label, short released) : base(title, price, imageUrl)
    {
        this.artist = artist;
        this.label = label;
        this.released = released;
    }

    public MusicCD(string title, decimal price, string artist, string label, short released) : base(title, price)
    {
        this.artist = artist;
        this.label = label;
        this.released = released;
    }

    public MusicCD(string artist,string title, decimal price,  short released) : base(title, price)
    {
        this.artist = artist;
        this.released = released;
    }

    public TimeSpan GetPlayingTime()
    {
        TimeSpan s1 = TimeSpan.Zero;

        foreach (Track t in TrackList)
        {
           s1= s1.Add(TimeSpan.ParseExact(t.Length, @"m\:ss", null));
        }
        return s1; 
    }
}