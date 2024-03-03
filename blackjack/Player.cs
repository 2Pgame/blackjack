using System;
using System.Collections;
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
        public float SumPoint = 0;
        public float SumPointP;
        public float SumPointE;

        public Player(Form1 form1)
        {
            Form1 = form1;
            Form1.pictureBoxP = form1.pictureBoxP;
            Form1.pictureBoxE = form1.pictureBoxE;
        }

        public Form1 Form1 { get; set; }

        public List<Card> CardDrowPlayer(List<Card> player2, List<Card> shuffle)
        {
            player2.Add(new Card(shuffle[Form1.sum].Suit, shuffle[Form1.sum].Number, shuffle[Form1.sum].Id, shuffle[Form1.sum].Point, shuffle[Form1.sum].Address));
            Form1.pictureBoxP[Form1.playerSum].ImageLocation = player2[Form1.playerSum].Address;

            Form1.sum++;
            Form1.playerSum++;
            SumPointP = 0;
            foreach (var card in player2)
            {
                SumPointP += card.Point;

            }
            AToChange(player2);


            SumPointP = 0;
            foreach (var card in player2)
            {
                SumPointP += card.Point;

            }
            Console.WriteLine($"現在{SumPointP}です");
            if (SumPointP <= 21)
            {
                Form1.PlayerPoint.Text = SumPointP.ToString();
            }
            else if (SumPointP >= 22)
            {
                Form1.PlayerPoint.Text = "Burst";
                Form1.CardDraw.Enabled = false;
            }
            else
            {
               
            }

            return player2;
        }

        List<Card> list1 = new List<Card>();
        public List<Card> CardDistributePlayer(List<Card> shuffle)
        {

            list1.Add(new Card(shuffle[Form1.sum].Suit, shuffle[Form1.sum].Number, shuffle[Form1.sum].Id, shuffle[Form1.sum].Point, shuffle[Form1.sum].Address));
            Form1.pictureBoxP[Form1.playerSum].ImageLocation = list1[Form1.playerSum].Address;
            Form1.playerSum++;
            Form1.sum++;
            return list1;
        }
        public float CalcPlayer(List<Card> list1)
        {
            SumPointP = 0;
            foreach (Card card in list1)
            {
                Console.WriteLine($"{card.Suit}{card.Number}");
                SumPointP += card.Point;
            }
            Console.WriteLine($"現在の合計は{SumPointP}です");

            AToChange(list1);
            SumPointP = 0;
            foreach (Card card in list1)
            {
                SumPointP += card.Point;
            }
            if (SumPointP <= 21)
            {
                Form1.PlayerPoint.Text = SumPointP.ToString();
            }
            else 
            {
                Form1.PlayerPoint.Text = "Burst";
            }


            return SumPointP;
        }
        public float CalcPlayerFirst(List<Card> list1)
        {
            SumPointP = 0;
            foreach (Card card in list1)
            {
                Console.WriteLine($"{card.Suit}{card.Number}");
                SumPointP += card.Point;
            }
            Console.WriteLine($"現在の合計は{SumPointP}です");

            foreach (var card in list1)
            {
                SumPointP += card.Point;

            }
            AToChange(list1);

            SumPointP = 0;
            foreach (Card card in list1)
            {
                SumPointP += card.Point;
            }
            if (SumPointP <= 20)
            {
                Form1.PlayerPoint.Text = SumPointP.ToString();
            }
            else if (SumPointP == 21)
            {
                Console.WriteLine("ブラックジャック");
                SumPointP += (float)0.5;
                Form1.PlayerPoint.Text = "Black\nJack";
                Form1.CardDraw.Enabled = false;
            }
            else
            {
                Form1.PlayerPoint.Text = "Burst";
            }


            return SumPointP;
        }
        void AToChange(List<Card> list1)
        {
            if (SumPointP >= 22)
            {
                foreach (var card in list1)
                {
                    if (card.Id == 1)
                    {
                        card.Point = 1;
                    }
                }
            }
            SumPointP = 0;
            foreach (var card in list1)
            {
                SumPointP += card.Point;
            }
            if (SumPointP >= 22)
            {
                foreach (var card in list1)
                {
                    if (card.Id == 14)
                    {
                        card.Point = 1;
                    }
                }
            }
            SumPointP = 0;
            foreach (var card in list1)
            {
                SumPointP += card.Point;
            }
            if (SumPointP >= 22)
            {
                foreach (var card in list1)
                {
                    if (card.Id == 27)
                    {
                        card.Point = 1;
                    }
                }
            }
            SumPointP = 0;
            foreach (var card in list1)
            {
                SumPointP += card.Point;
            }
            if (SumPointP >= 22)
            {
                foreach (var card in list1)
                {
                    if (card.Id == 40)
                    {
                        card.Point = 1;
                    }
                }
            }
        }
    }
}


