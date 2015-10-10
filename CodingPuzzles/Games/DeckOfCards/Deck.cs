using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles.Games
{
    //Create a DeckOfCards class with a Shuffle and Deal Method
    //Source: Head First C# 3rd Edition, p. 383
    class Deck
    {
        private Stack<Card> _deckOfCards;
        private Random _random = new Random();

        public Deck()
        {
            _deckOfCards = new Stack<Card>();
            CreateDeck();
        }

        //Create Deck of Cards
        private void CreateDeck()
        {
            //Get number of items in enum Suit
            int numSuits = Enum.GetNames(typeof(Suit)).Length;
            int numValues = Enum.GetNames(typeof(Value)).Length;
            for (int suit = 0; suit < numSuits; suit++)
            {
                for (int value = 1; value <= numValues; value++)
                {
                    Card card = new Card((Suit)suit, (Value)value);
                    _deckOfCards.Push(card);
                }
            }
        }

        public Card Deal()
        {
            if (_deckOfCards.Count == 0)
                throw new Exception("Empty Deck");
            return _deckOfCards.Pop();
        }

        //Shuffle cards
        public void Shuffle()
        {
            List<Card> originalDeck = _deckOfCards.ToList();
            _deckOfCards.Clear();
            while (originalDeck.Count != 0)
            {
                int cardToMove = _random.Next(originalDeck.Count);
                _deckOfCards.Push(originalDeck[cardToMove]);
                originalDeck.RemoveAt(cardToMove);
            }
        }
        //Deck d = new Deck();
        //d.Shuffle();
        //for (int i = 0; i < 52; i++)
        //{
        //    Card c = d.Deal();
        //    Console.WriteLine(c.Name);
        //}
    }
}