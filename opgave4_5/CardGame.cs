namespace opgave4_5;
using static Card;
public class CardGame
{
   public List<Card> Cards { get; } = new List<Card>();
    
    public void AddCard(Rank rank, Suit suit)
    {
        Card card = new Card(suit, rank);
        Cards.Add(card);
    }

    public List<Card> FilterCardgame(FilterCardDelegate filter)
    {
        List<Card> filtreret = new List<Card>();

        foreach (var card in Cards)
        {
            if (filter(card))
            {
                filtreret.Add(card);
            }
        }

        return filtreret;
    }
}