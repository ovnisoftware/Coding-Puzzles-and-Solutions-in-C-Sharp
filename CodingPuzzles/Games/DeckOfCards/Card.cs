namespace CodingPuzzles.Games
{
    public class Card
    {
        public Value Value { get; set; }
        public Suit Suit { get; set; }
        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }
        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }
    }
}