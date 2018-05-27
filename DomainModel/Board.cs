using System.Collections.Generic;

namespace SHolitaire.DomainModel
{
    public class Board
    {
        List<Card> FieldDeck = new List<Card>();

        List<List<Card>> FieldStack = new List<List<Card>>();

        List<List<Card>> FieldDone = new List<List<Card>>();
    }
}
