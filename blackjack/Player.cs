using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    internal class Player
    {
        public int Sum = 1;
        public int Point;
        public int SumPoint = 0;

        public List<Card> CardDistribute(List<Card> shuffle)
        {
            List<Card> list1 = new List<Card>();
            for (int i = 0; i < 4; i = i + 2)
            {
                list1.Add(new Card(shuffle[i].Suit, shuffle[i].Number, shuffle[i].Id, shuffle[i].Point, shuffle[i].Address));
            }
            foreach (Card card in list1)
            {
                Console.WriteLine($"{card.Suit}{card.Number}");
                SumPoint += card.Point;
            }
            Console.WriteLine($"現在の合計は{SumPoint}です");
            foreach (Card card in list1)
            {
                SumPoint = 0;
                if (SumPoint > 21)
                {
                    if (card.Id == 1 || card.Id == 14 || card.Id == 27 || card.Id == 40)
                    {
                        card.Point = 1;
                    }
                }
                SumPoint += card.Point;
            }

            return list1;
        }
        public List<Card> CardDrow(List<Card> player, List<Card> shuffle)
        {
            player.Add(new Card(shuffle[3 + Sum].Suit, shuffle[3 + Sum].Number, shuffle[3 + Sum].Id, shuffle[3 + Sum].Point, shuffle[3 + Sum].Address));
            Console.WriteLine($"{player[1 + Sum].Suit}{player[1 + Sum].Number}");

            Sum++;
            SumPoint = 0;
            foreach (var card in player)
            {
                SumPoint += card.Point;

            }

            for (int i = 0; i < player.Count; i++)
            {
                if (SumPoint > 21)
                {
                    if (player[i].Id == 1)
                    {
                        player[i].Point = 1;
                    }
                    else if (player[i].Id == 14)
                    {
                        player[i].Point = 1;
                    }
                    else if (player[i].Id == 27)
                    {
                        player[i].Point = 1;
                    }
                    else if (player[i].Id == 40)
                    {
                        player[i].Point = 1;
                    }
                }
            }

            SumPoint = 0;
            foreach (var card in player)
            {
                SumPoint += card.Point;

            }
            Console.WriteLine($"現在{SumPoint}です");

            return player;
        }

    }
}

