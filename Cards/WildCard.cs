using System;
using Assignment3.ProvidedCode;

namespace Assignment3
{
    public class WildCard : Card
    {
        public CardAction Action { get; set; }
        public WildCard(CardAction action)
        {
            Action = action;
        }

        public override bool IsPlayable(Card previousCard)
        {
            return true;
        }
    }
}

