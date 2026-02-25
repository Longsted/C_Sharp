namespace opgave4_5;

public class Card
{
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public enum Rank
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    private Suit _suit;
    private Rank _rank;

    public Card(Suit suit, Rank rank)
    {
        _suit = suit;
        _rank = rank;
    }
    // public gettere
public Suit CardSuit => _suit;
public Rank CardRank => _rank;
    
    public override string ToString()
    {
        return _suit + " " + _rank;
    }

   public delegate bool FilterCardDelegate(Card card);

    public FilterCardDelegate Filter;


}