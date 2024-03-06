using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
                if (SumPointE == 22)
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
        public float CardDrowEnemy(List<Card> enemys, List<Card> shuffle)
        {
            Form1.pictureBoxE[Form1.enemySum - 1].Image = null;
            Form1.pictureBoxE[Form1.enemySum - 1].ImageLocation = enemys[Form1.enemySum - 1].Address;

            SumPointE = 0;
            foreach (Card enemy in enemys)
            {
                SumPointE += enemy.Point;
            }
            if (SumPointE == 21)
            {
                Console.WriteLine("ブラックジャック");
                SumPointE += (float)0.5;
                Form1.DealerPoint.Text = "Black\nJack";

            }
            if (SumPointE >= 22)
            {
                foreach (var card in enemys)
                {
                    if (card.Id == 1)
                    {
                        card.Point = 1;
                    }
                }

                SumPointE = 0;
                foreach (var card in enemys)
                {
                    SumPointE += card.Point;
                }
                if (SumPointE >= 22)
                {
                    foreach (var card in enemys)
                    {
                        if (card.Id == 14)
                        {
                            card.Point = 1;
                        }
                    }
                }
                SumPointE = 0;
                foreach (var card in enemys)
                {
                    SumPointE += card.Point;
                }
                if (SumPointE >= 22)
                {
                    foreach (var card in enemys)
                    {
                        if (card.Id == 27)
                        {
                            card.Point = 1;
                        }
                    }
                }
                SumPointE = 0;
                foreach (var card in enemys)
                {
                    SumPointE += card.Point;
                }
                if (SumPointE >= 22)
                {
                    foreach (var card in enemys)
                    {
                        if (card.Id == 40)
                        {
                            card.Point = 1;
                        }
                    }
                }
                SumPointE = 0;
                foreach (var card in enemys)
                {
                    SumPointE += card.Point;

                }
            }

            while (SumPointE < 17)
            {
                enemys.Add(new Card(shuffle[Form1.sum].Suit, shuffle[Form1.sum].Number, shuffle[Form1.sum].Id, shuffle[Form1.sum].Point, shuffle[Form1.sum].Address));
                Form1.pictureBoxE[Form1.enemySum].ImageLocation = enemys[Form1.enemySum].Address;
                Form1.player2.Play();
                Form1.sum++;
                Form1.enemySum++;
                SumPointE = 0;
                foreach (var card in enemys)
                {
                    SumPointE += card.Point;

                }
                Form1.DealerPoint.Text = SumPointE.ToString();
                if (SumPointE >= 22)
                {
                    foreach (var card in enemys)
                    {
                        if (card.Id == 1)
                        {
                            card.Point = 1;
                        }
                    }
                }
                SumPointE = 0;
                foreach (var card in enemys)
                {
                    SumPointE += card.Point;
                }
                if (SumPointE >= 22)
                {
                    foreach (var card in enemys)
                    {
                        if (card.Id == 14)
                        {
                            card.Point = 1;
                        }
                    }
                }
                SumPointE = 0;
                foreach (var card in enemys)
                {
                    SumPointE += card.Point;
                }
                if (SumPointE >= 22)
                {
                    foreach (var card in enemys)
                    {
                        if (card.Id == 27)
                        {
                            card.Point = 1;
                        }
                    }
                }
                SumPointE = 0;
                foreach (var card in enemys)
                {
                    SumPointE += card.Point;
                }
                if (SumPointE >= 22)
                {
                    foreach (var card in enemys)
                    {
                        if (card.Id == 40)
                        {
                            card.Point = 1;
                        }
                    }
                }
                SumPointE = 0;
                foreach (var card in enemys)
                {
                    SumPointE += card.Point;

                }
            }


            Console.WriteLine($"現在{SumPointE}です");
            if (SumPointE <= 21)
            {
                Form1.DealerPoint.Text = SumPointE.ToString();
            }
            else if (SumPointE >= 22)
            {
                Form1.DealerPoint.Text = "Burst";
            }

            return SumPointE;
        }

        public void BJJudge(float sumPoint1, float sumPoint2)
        {
            if (sumPoint2 == 21.5)
            {
                Form1.coin += Form1.insBet * 3;
                Form1.coinlabel.Text = Form1.coin.ToString();
                Console.WriteLine(Form1.insBet * 3 + "を獲得しました。");
            }

            if (sumPoint1 >= 22)
            {
                Console.WriteLine("プレイヤーの負け");
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Blue;
                Form1.WinOrLoseP.Text = "負け";
                Form1.CrownPictureE.Visible = true;
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Red;
                Form1.WinOrLoseE.Text = "勝ち";
                Form1.coinlabel.Text = Form1.coin.ToString();
            }
            else if (sumPoint2 >= 22)
            {
                Console.WriteLine("プレイヤーの勝ち");
                Form1.CrownPictureP.Visible = true;
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Red;
                Form1.WinOrLoseP.Text = "勝ち";
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Blue;
                Form1.WinOrLoseE.Text = "負け";
                Form1.player.controls.pause();// ポーズ(play()で再開)
                Form1.coin += Form1.bet * 2;
                Form1.coinlabel.Text = Form1.coin.ToString();
                if (Form1.bet >= 10)
                {
                    SoundPlayer player1 = new SoundPlayer(@"ファンファーレ.wav");
                    player1.Play();
                    Form1.Start2();
                }
                else
                {
                    SoundPlayer player1 = new SoundPlayer(@"勝ち.wav");
                    player1.Play();
                    Form1.Start();
                }


            }
            else if (sumPoint1 == sumPoint2)
            {
                Console.WriteLine("引き分け");
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Purple;
                Form1.WinOrLoseP.Text = "引き分け";
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Purple;
                Form1.WinOrLoseE.Text = "引き分け";
                Form1.coin += Form1.bet;
                Form1.coinlabel.Text = Form1.coin.ToString();
            }
            else if (sumPoint1 > sumPoint2)
            {
                Console.WriteLine("プレイヤーの勝ち");
                Form1.CrownPictureP.Visible = true;
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Red;
                Form1.WinOrLoseP.Text = "勝ち";
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Blue;
                Form1.WinOrLoseE.Text = "負け";
                Form1.player.controls.pause();// ポーズ(play()で再開)
                if (Form1.bet >= 10)
                {
                    SoundPlayer player1 = new SoundPlayer(@"ファンファーレ.wav");
                    player1.Play();
                    Form1.Start2();
                }
                else
                {
                    SoundPlayer player1 = new SoundPlayer(@"勝ち.wav");
                    player1.Play();
                    Form1.Start();
                }
                if (sumPoint1 == 21.5)
                {
                    Form1.coin += (int)(Form1.bet * 2.5);
                    Form1.coinlabel.Text = Form1.coin.ToString();
                }
                else 
                {
                
                Form1.coin += Form1.bet * 2;
                Form1.coinlabel.Text = Form1.coin.ToString();
                }

            }
            else if (sumPoint2 > sumPoint1)
            {
                Console.WriteLine("プレイヤーの負け");
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Blue;
                Form1.WinOrLoseP.Text = "負け";
                Form1.CrownPictureE.Visible = true;
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Red;
                Form1.WinOrLoseE.Text = "勝ち";
                Form1.coinlabel.Text = Form1.coin.ToString();
            }


        }
        public void BJJudgeS(float sumPoint1,float sumPoint2, float sumPoint3)
        {
            if (sumPoint3 == 21.5)
            {
                Form1.coin += Form1.insBet * 3;
                Form1.coinlabel.Text = Form1.coin.ToString();
                Console.WriteLine(Form1.insBet * 3 + "を獲得しました。");
            }

            else if (sumPoint1 >= 22 && sumPoint2 >= 22)
            {
                Console.WriteLine("プレイヤーの負け");
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Blue;
                Form1.WinOrLoseP.Text = "負け";
                Form1.CrownPictureE.Visible = true;
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Red;
                Form1.WinOrLoseE.Text = "勝ち";
            }
            else if (sumPoint1 >= 22 && sumPoint2 < sumPoint3)
            {
                Console.WriteLine("プレイヤーの負け");
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Blue;
                Form1.WinOrLoseP.Text = "負け";
                Form1.CrownPictureE.Visible = true;
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Red;
                Form1.WinOrLoseE.Text = "勝ち";
            }
            else if (sumPoint1 < sumPoint3 && sumPoint2 >= 22)
            {
                Console.WriteLine("プレイヤーの負け");
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Blue;
                Form1.WinOrLoseP.Text = "負け";
                Form1.CrownPictureE.Visible = true;
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Red;
                Form1.WinOrLoseE.Text = "勝ち";
            }

            else if (sumPoint3 >= 22)
            {
                Console.WriteLine("プレイヤーの勝ち");
                Form1.CrownPictureP.Visible = true;
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Red;
                Form1.WinOrLoseP.Text = "勝ち";
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Blue;
                Form1.WinOrLoseE.Text = "負け";
                Form1.player.controls.pause();// ポーズ(play()で再開)
                Form1.coin += Form1.bet * 2;
                Form1.coinlabel.Text = Form1.coin.ToString();
                if (Form1.bet >= 10)
                {
                    SoundPlayer player1 = new SoundPlayer(@"ファンファーレ.wav");
                    player1.Play();
                    Form1.Start2();
                }
                else
                {
                    SoundPlayer player1 = new SoundPlayer(@"勝ち.wav");
                    player1.Play();
                    Form1.Start();
                }


            }
            else if ((sumPoint1 == sumPoint3 && sumPoint1 <= 22) && (sumPoint2 == sumPoint3&& sumPoint2 <=22))
            {
                Console.WriteLine("引き分け");
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Purple;
                Form1.WinOrLoseP.Text = "引き分け";
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Purple;
                Form1.WinOrLoseE.Text = "引き分け";
                Form1.coin += Form1.bet;
                Form1.coin += Form1.bet;
                Form1.coinlabel.Text = Form1.coin.ToString();
            }
            else if ((sumPoint1 > sumPoint3 && sumPoint1 >= 22 )  && sumPoint2 == sumPoint3)
            {
                Console.WriteLine("引き分け");
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Purple;
                Form1.WinOrLoseP.Text = "引き分け";
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Purple;
                Form1.WinOrLoseE.Text = "引き分け";
                Form1.coin += Form1.bet;
                Form1.coinlabel.Text = Form1.coin.ToString();
            }
            else if (sumPoint1 == sumPoint3&& (sumPoint2 > sumPoint3 && sumPoint2 >= 22))
            {
                Console.WriteLine("引き分け");
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Purple;
                Form1.WinOrLoseP.Text = "引き分け";
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Purple;
                Form1.WinOrLoseE.Text = "引き分け";
                Form1.coin += Form1.bet;
                Form1.coinlabel.Text = Form1.coin.ToString();
            }
            else if (sumPoint1 < sumPoint3 && sumPoint2 == sumPoint3)
            {
                Console.WriteLine("引き分け");
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Purple;
                Form1.WinOrLoseP.Text = "引き分け";
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Purple;
                Form1.WinOrLoseE.Text = "引き分け";
                Form1.coin += Form1.bet;
                Form1.coinlabel.Text = Form1.coin.ToString();
            }
            else if (sumPoint1 == sumPoint3 && sumPoint2 < sumPoint3)
            {
                Console.WriteLine("引き分け");
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Purple;
                Form1.WinOrLoseP.Text = "引き分け";
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Purple;
                Form1.WinOrLoseE.Text = "引き分け";
                Form1.coin += Form1.bet;
                Form1.coinlabel.Text = Form1.coin.ToString();
            }
            else if ((sumPoint1 > sumPoint3 && sumPoint1 <= 21.5) && (sumPoint2 > sumPoint3 && sumPoint2 <= 21.5))
            {
                Console.WriteLine("プレイヤーの勝ち");
                Form1.CrownPictureP.Visible = true;
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Red;
                Form1.WinOrLoseP.Text = "勝ち";
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Blue;
                Form1.WinOrLoseE.Text = "負け";
                Form1.player.controls.pause();// ポーズ(play()で再開)
                if (Form1.bet >= 10)
                {
                    SoundPlayer player1 = new SoundPlayer(@"ファンファーレ.wav");
                    player1.Play();
                    Form1.Start2();
                }
                else
                {
                    SoundPlayer player1 = new SoundPlayer(@"勝ち.wav");
                    player1.Play();
                    Form1.Start();
                }
                if (sumPoint1 == 21.5 && sumPoint2 == 21.5)
                {
                    Form1.coin += (int)(Form1.bet * 2.5);
                    Form1.coinlabel.Text = Form1.coin.ToString();
                }
                else if (sumPoint1 == 21.5 && sumPoint2 > sumPoint3)
                {
                    Form1.coin += (int)(Form1.bet * 2.5);
                    Form1.coin += (int)(Form1.bet * 2);
                    Form1.coinlabel.Text = Form1.coin.ToString();
                }
                else if (sumPoint1 > sumPoint3 && sumPoint2 == 21.5)
                {
                    Form1.coin += (int)(Form1.bet * 2.5);
                    Form1.coin += (int)(Form1.bet * 2);
                    Form1.coinlabel.Text = Form1.coin.ToString();
                }

            }



            else if (sumPoint1 > sumPoint3 && sumPoint1<=21.5|| sumPoint2 > sumPoint3 && sumPoint2 <= 21.5)
            {
                Console.WriteLine("プレイヤーの勝ち");
                Form1.CrownPictureP.Visible = true;
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Red;
                Form1.WinOrLoseP.Text = "勝ち";
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Blue;
                Form1.WinOrLoseE.Text = "負け";
                Form1.player.controls.pause();// ポーズ(play()で再開)
                if (Form1.bet >= 10)
                {
                    SoundPlayer player1 = new SoundPlayer(@"ファンファーレ.wav");
                    player1.Play();
                    Form1.Start2();
                }
                else
                {
                    SoundPlayer player1 = new SoundPlayer(@"勝ち.wav");
                    player1.Play();
                    Form1.Start();
                }
                if (sumPoint1 == 21.5 || sumPoint2 == 21.5)
                {
                    Form1.coin += (int)(Form1.bet * 2.5);
                    Form1.coinlabel.Text = Form1.coin.ToString();
                }
                else
                {

                    Form1.coin += Form1.bet * 2;
                    Form1.coinlabel.Text = Form1.coin.ToString();
                }

            }
            else if (sumPoint3 > sumPoint1 && sumPoint3 > sumPoint2)
            {
                Console.WriteLine("プレイヤーの負け");
                Form1.WinOrLoseP.Visible = true;
                Form1.WinOrLoseP.ForeColor = System.Drawing.Color.Blue;
                Form1.WinOrLoseP.Text = "負け";
                Form1.CrownPictureE.Visible = true;
                Form1.WinOrLoseE.Visible = true;
                Form1.WinOrLoseE.ForeColor = System.Drawing.Color.Red;
                Form1.WinOrLoseE.Text = "勝ち";
                Form1.coinlabel.Text = Form1.coin.ToString();
            }


        }

    }
}

