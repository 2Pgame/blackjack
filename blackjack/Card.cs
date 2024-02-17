using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    enum CardSuit
    {
        Club,
        Spade,
        Heart,
        Diamond
    internal class Card
    {

        public CardSuit Suit;
        public int Number;
        public int Id;
        public int Point;
        public int SumPoint;
        public string Address;
        public Card(CardSuit suit, int number, int id, int point, string address)
        {
            Suit = suit;
            Number = number;
            Id = id;
            Point = point;
            Address = address;
        }
        public int PointCount(int number)
        {
            if (Number == 1)
            {
                Point = 11;
            }
            if (Number >= 10)
            {
                Point = 10;
            }
            return Point;
        }
    }
}

