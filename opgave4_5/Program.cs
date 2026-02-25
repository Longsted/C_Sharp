namespace opgave4_5{
    
   public static class Program
    {
        static void Main(string[] args)
        {
            CardGame game = new CardGame();
               
            foreach(Card.Suit suit in  Enum.GetValues( typeof(Card.Suit)))
            {
                foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
                {
                    game.AddCard(rank, suit);
                }
            }


            // List<Card> billedKort = game.FilterCardgame(FilterByPicture);
            //
            // foreach (var card in billedKort)
            // {
            //     Console.WriteLine(card.ToString());
            // }
            var hearts = game.Cards.Where(card => card.CardSuit == Card.Suit.Hearts );
            foreach (var card in hearts)
            {
                Console.WriteLine(card.ToString());
            }

            var aceIsPartOfGame = game.Cards.Exists(ace => ace.CardRank == Card.Rank.Ace);
            Console.WriteLine(aceIsPartOfGame);

        }
        public static bool FilterByKlør(Card card)
        {
            return card.CardSuit == Card.Suit.Clubs;
        }

        public static bool FilterByPicture(Card card)
        {
            Card.Rank[] cards = new[] { Card.Rank.Jack,Card.Rank.Queen,Card.Rank.King};
            
            return cards.Contains(card.CardRank);
        }

        public static bool FilterByNumber(Card card)
        {
            Card.Rank[] nonPictureCards = new[]
            {
                Card.Rank.Ace,
                Card.Rank.Two,
                Card.Rank.Three,
                Card.Rank.Four,
                Card.Rank.Five,
                Card.Rank.Six,
                Card.Rank.Seven,
                Card.Rank.Eight,
                Card.Rank.Nine,
                Card.Rank.Ten
            };
            return  nonPictureCards.Contains(card.CardRank);
        }

        
    }
    
    
}

