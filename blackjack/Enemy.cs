using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack
{
    internal class Enemy : Player
    {

        public float SumPoint1 = 0;

        public Enemy(Form1 form1) : base(form1)
        {
            Form1 = form1;
            Form1.pictureBoxP = form1.pictureBoxP;
            Form1.pictureBoxE = form1.pictureBoxE;
        }
        List<Card> list2 = new List<Card>();
        public List<Card> CardDistributeEnemy(List<Card> shuffle)
        {

            list2.Add(new Card(shuffle[Form1.sum].Suit, shuffle[Form1.sum].Number, shuffle[Form1.sum].Id, shuffle[Form1.sum].Point, shuffle[Form1.sum].Address));
            Form1.pictureBoxE[Form1.enemySum].ImageLocation = list2[Form1.enemySum].Address;
            Form1.enemySum++;
            Form1.sum++;
            foreach (var card in list2)
            {
                SumPointE += card.Point;
            }

            for (int i = 0; i < list2.Count; i++)
            {
                if (SumPointE > 21)
                {
                    if (list2[i].Id == 1)
                    {
                        list2[i].Point = 1;
                    }
                    else if (list2[i].Id == 14)
                    {
                        list2[i].Point = 1;
                    }
                    else if (list2[i].Id == 27)
                    {
                        list2[i].Point = 1;
                    }
                    else if (list2[i].Id == 40)
                    {
                        list2[i].Point = 1;
                    }
                }
            }
            return list2;
        }
        public float CardDrowEnemy(List<Card> enemy, List<Card> shuffle)
        {
            Form1.pictureBoxE[1].Image = null;
            Form1.pictureBoxE[1].ImageLocation = enemy[1].Address;

            SumPointE = 0;
            foreach (Card ene in enemy)
            { 
                SumPointE += ene.Point;
            }
            Form1.DealerPoint.Text = SumPointE.ToString();
            while (SumPointE < 17)
            {
                enemy.Add(new Card(shuffle[Form1.sum].Suit, shuffle[Form1.sum].Number, shuffle[Form1.sum].Id, shuffle[Form1.sum].Point, shuffle[Form1.sum].Address));
                Form1.pictureBoxE[Form1.enemySum].ImageLocation = enemy[Form1.enemySum].Address;

                Form1.sum++;
                Form1.enemySum++;
                SumPointE = 0;
                foreach (var card in enemy)
                {
                    SumPointE += card.Point;

                }
                Form1.DealerPoint.Text = SumPointE.ToString();
                for (int i = 0; i < enemy.Count; i++)
                {
                    if (SumPointE > 21)
                    {
                        if (enemy[i].Id == 1)
                        {
                            enemy[i].Point = 1;
                        }
                        else if (enemy[i].Id == 14)
                        {
                            enemy[i].Point = 1;
                        }
                        else if (enemy[i].Id == 27)
                        {
                            enemy[i].Point = 1;
                        }
                        else if (enemy[i].Id == 40)
                        {
                            enemy[i].Point = 1;
                        }
                    }
                }

                SumPointE = 0;
                foreach (var card in enemy)
                {
                    SumPointE += card.Point;

                }
                Console.WriteLine($"現在{SumPointE}です");
                if (SumPointE <= 21)
                {
                    Form1.DealerPoint.Text = SumPointE.ToString();
                }
                else
                {
                    Form1.DealerPoint.Text = "Burst";
                }
            }
            return SumPointE;
        }

        public void BJJudge(float sumPoint1, float sumPoint2)
        {

            if (sumPoint1 >= 22)
            {
                Console.WriteLine("プレイヤーの負け");
            }
            else if (sumPoint2 >= 22)
            {
                Console.WriteLine("プレイヤーの勝ち");
            }
            else if (sumPoint1 == sumPoint2)
            {
                Console.WriteLine("引き分け");
            }
            else if (sumPoint1 > sumPoint2)
            {
                Console.WriteLine("プレイヤーの勝ち");
            }
            else if (sumPoint2 > sumPoint1 )
            {
                Console.WriteLine("プレイヤーの負け");
            }
        }
    }
}

