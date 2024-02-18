using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    internal class Enemy : Player
    {

        public int SumPoint1 = 0;
        public void CardDistribute(List<Card> shuffle)
        {
            List<Card> list1 = new List<Card>();
            for (int i = 1; i < 4; i = i + 2)
            {
                list1.Add(new Card(shuffle[i].Suit, shuffle[i].Number, shuffle[i].Id, shuffle[i].Point, shuffle[i].Address));
            }
            foreach (Card card in list1)
            {
                Console.WriteLine($"{card.Suit}{card.Number}");
                SumPoint1 += card.Point;
            }
            if (SumPoint1 < 17)
            {

                int Sum1 = 1;
                list1.Add(new Card(shuffle[3 + Sum].Suit, shuffle[3 + Sum].Number, shuffle[3 + Sum].Id, shuffle[3 + Sum].Point, shuffle[3 + Sum].Address));
                Console.WriteLine($"{list1[1 + Sum1].Suit}{list1[1 + Sum1].Number}");
                Sum++;
                Sum1++;
                SumPoint1 = 0;

                foreach (var card in list1)
                {

                    SumPoint1 += card.Point;

                }

            }

            for (int i = 0; i < list1.Count; i++)
            {
                if (SumPoint1 > 21)
                {
                    if (list1[i].Id == 1)
                    {
                        list1[i].Point = 1;
                    }
                    else if (list1[i].Id == 14)
                    {
                        list1[i].Point = 1;
                    }
                    else if (list1[i].Id == 27)
                    {
                        list1[i].Point = 1;
                    }
                    else if (list1[i].Id == 40)
                    {
                        list1[i].Point = 1;
                    }
                }
            }

            SumPoint1 = 0;
            foreach (var card in list1)
            {
                SumPoint1 += card.Point;

            }
            Console.WriteLine($"敵の点数は{SumPoint1}です");
        }
        public void BJJudge(int sumPoint, int sumPoint1)
        {
            if (sumPoint1 == sumPoint)
            {
                Console.WriteLine("引き分け");
            }
            else if (sumPoint1 < sumPoint && sumPoint < 22)
            {
                Console.WriteLine("プレイヤーの勝ち");
            }
            else if (sumPoint1 > sumPoint && sumPoint1 < 22 && sumPoint > 21)
            {
                Console.WriteLine("プレイヤーの負け");
            }
            else if (sumPoint1 > 21 && sumPoint > 21)
            {
                Console.WriteLine("引き分け");
            }
            else if (sumPoint1 > 21)
            {
                Console.WriteLine("プレイヤーの勝ち");
            }
            else
            {
                Console.WriteLine("プレイヤーの負け");
            }
        }
    }
}

