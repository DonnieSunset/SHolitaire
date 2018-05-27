using System;
using System.Collections.Generic;

namespace SHolitaire.DomainModel
{
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

    public enum Suit
    {
        Spades,
        Hearts,
        Diamonds,
        Clubs
    }

    public class Card
    {
        Rank rank;
        Suit suit;

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public bool Opened { get; set; }
    }

    public abstract class Deck
    {
        public List<Card> Cards { get; protected set; }
    }

    public class ClassicDeck : Deck
    {
        public ClassicDeck()
        {
            Cards = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Cards.Add(new Card(rank, suit));
                }
            }
        }
    }

    public class SpiderDeck : Deck
    {
        public SpiderDeck()
        {
            Cards = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Cards.Add(new Card(rank, suit));
                    Cards.Add(new Card(rank, suit));
                }
            }
        }
    }
}
