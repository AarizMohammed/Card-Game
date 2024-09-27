using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.ProvidedCode
{
    internal class Player
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
        public static Stack<Card> DrawPile { get; } = new Stack<Card>();
        public static Stack<Card> DiscardPile { get; set; } = new Stack<Card>();

        public Player(string name)
        {
            Name = name;
            Cards = new List<Card>();
        }

        public Card GetCard()
        {
            return DrawPile.Pop();
        }

        public void PlaceCard(Card card)
        {
            if (card.IsPlayable(DiscardPile.Peek()))
            {
                Cards.Remove(card);
                DiscardPile.Push(card);
            }
        }

        public void PlaceCard(Card wildCard, CardColor color)
        {
            wildCard.Color = color;
            Cards.Remove(wildCard);
            DiscardPile.Push(wildCard);

        }

    }
}
