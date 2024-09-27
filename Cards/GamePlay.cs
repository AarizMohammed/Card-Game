using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.ProvidedCode
{
    internal class GamePlay
    {


        public static void RegenerateDrawPile()
        {
            if (Player.DrawPile.Count == 0)
            {
                Card topCard = Player.DiscardPile.Pop();

                List<Card> shuffleDeck = Player.DiscardPile.ToList();
                Player.DiscardPile.Clear();
                Shuffle(shuffleDeck);




                foreach (Card card in shuffleDeck)
                {
                    Player.DrawPile.Push(card);
                }

                Player.DrawPile.Push(topCard);
            }
        }



        public static void Shuffle(List<Card> cardsToShuffle)
        {
            Random random = new Random();
            int n = cardsToShuffle.Count;

            while (n > 1)
            {

                n--;
                int i = random.Next(n + 1);
                Card holdValue = cardsToShuffle[i];
                cardsToShuffle[i] = cardsToShuffle[n];
                cardsToShuffle[n] = holdValue;
            }
        }

    }
}
