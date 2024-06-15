using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch._24.Models
{
    public class Card
    {
        public CardRank CardRank { get; set; }
        public CardColor Color { get; set; }

        public Card(CardRank cardRank, CardColor color)
        {
            CardRank = cardRank;
            Color = color;
        }

        public bool IsSymbolCard()
        {
            if (CardRank == CardRank.Dollar || 
                CardRank == CardRank.Caret || 
                CardRank == CardRank.Percent || 
                CardRank == CardRank.Ampersand)
            {
                return true;
            }
            return false;
        }

        public string ToString()
        {
            return $"The {Color} {CardRank}";
        }
    }

    public enum CardRank
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Dollar,
        Percent,
        Caret,
        Ampersand
    }

    public enum CardColor
    {
        Red,
        Green,
        Blue,
        Yellow
    }
}
