using System;
using Assignment3.ProvidedCode;
using System.Drawing;

namespace Assignment3
{
    public class ActionColorCard : Card
    {
        public CardAction Action { get; set; }
        public ActionColorCard(CardAction action, CardColor color)
        {
            Action = action;
            Color = color;
        }

        public override bool IsPlayable(Card previousCard)
        {
            if (previousCard is IColorCard colorCard)
            {
                return colorCard.Color == Color;
            }
            return false;
        }
    }
}

