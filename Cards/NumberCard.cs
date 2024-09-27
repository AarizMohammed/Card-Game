using System;
using Assignment3.ProvidedCode;
using System.Drawing;

namespace Assignment3
{
    public class NumberCard : Card
    {
        public int Number { get; set; }
        public NumberCard(CardColor color, int number)
        {
            Color = color;
            Number = number;
        }

        public override bool IsPlayable(Card previousCard)
        {
            if (previousCard is NumberCard numberCard)
            {
                return numberCard.Color == Color || numberCard.Number == Number;
            }
            else if (previousCard is IColorCard colorCard)
            {
                return colorCard.Color == Color;
            }
            return false;
        }

    }
}

