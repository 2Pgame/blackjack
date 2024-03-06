using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.IO;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;

namespace blackjack
{
    public partial class Form1 : Form
    {
        public WindowsMediaPlayer player = new WindowsMediaPlayer();
        public SoundPlayer player2 = new SoundPlayer(@"カードを配る.wav");
        Player player1;
        Enemy enemy;
        public Form1()
        {
            InitializeComponent();
            player1 = new Player(this);
            enemy = new Enemy(this);
            // ループ再生を指定
            player.settings.setMode("loop", true);
            // 通常は自動再生にファイルを指定すればループ再生がはじまります
            player.URL = @"BGM.wav";
            player.controls.play();
            //背景にカジノを使う
            pictureBox0.ImageLocation = "image\\cajino.png";
            BetButton.ImageLocation = "image\\coin.png";
            BetButton.Parent = pictureBox0;
            DealerPoint.Parent = pictureBox0;
            PlayerPoint.Parent = pictureBox0;
            PlayerPoint3.Parent = pictureBox0;
            SplitPoint1.Parent = pictureBox0;
            SplitPoint2.Parent = pictureBox0;
            rest.Parent = pictureBox0;
            coinlabel.Parent = pictureBox0;
            PlayerCard1.Parent = pictureBox0;
            PlayerCard2.Parent = pictureBox0;
            PlayerCard3.Parent = pictureBox0;
            PlayerCard4.Parent = pictureBox0;
            PlayerCard5.Parent = pictureBox0;
            PlayerCard6.Parent = pictureBox0;
            DealerCard1.Parent = pictureBox0;
            DealerCard2.Parent = pictureBox0;
            DealerCard3.Parent = pictureBox0;
            DealerCard4.Parent = pictureBox0;
            DealerCard5.Parent = pictureBox0;
            DealerCard6.Parent = pictureBox0;

            CrownPictureP.Parent = pictureBox0;
            CrownPictureE.Parent = pictureBox0;
            WinOrLoseE.Parent = pictureBox0;
            WinOrLoseP.Parent = pictureBox0;
            CrownPictureP.ImageLocation = "image\\crown_01_gold.png";
            CrownPictureE.ImageLocation = "image\\crown_01_gold.png";
            CrownPictureP.Visible = false;
            CrownPictureE.Visible = false;
            WinOrLoseP.Visible = false;
            WinOrLoseE.Visible = false;
            label2.Text = "Player";

        }
        List<Card> cards = new List<Card>();
        List<Card> shuffle = new List<Card>();
        List<Card> list1 = new List<Card>();
        List<Card> list2 = new List<Card>();
        List<Card> testBJ = new List<Card>();
        List<Card> testSplit = new List<Card>();
        List<Card> splitlist1 = new List<Card>();
        List<Card> splitlist2 = new List<Card>();
        public List<PictureBox> pictureBoxP = new List<PictureBox>();
        public List<PictureBox> pictureBoxE = new List<PictureBox>();
        public List<PictureBox> splitpictureBoxP1 = new List<PictureBox>();
        public List<PictureBox> splitpictureBoxP2 = new List<PictureBox>();
        public int sum = 0;
        public int playerSum;
        public int enemySum;
        public int coin = 10;
        public int bet;
        public int insBet;
        public string doubledown;
        public int splitBet;
        public int splitCount1;
        public int splitCount2;
        public int splitNumber1 = 1;
        public int splitNumber2 = 1;
        public int splitPoint = 3;


        public float SumPointP;
        public float SumPointP2;
        private float SumPointE;
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            // 日本語が表示できるようにする
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            // インデントフォーマットあり
            WriteIndented = true
        };
        private void NewGameClicked(object sender, EventArgs e)
        {
            if (bet == 0)
            {
                MessageBox.Show("最低１枚かけてください");
            }
            else
            {
                CardCreate();
                TestBJ(cards);
                TestSplitA(cards);
                BetButton1.Enabled = false;
                Bet10Button.Enabled = false;
                ShuffleCard.Enabled = true;
                NewGame.Enabled = false;
                Input.Enabled = false;
                pictureBoxP.Add(PlayerCard1);
                pictureBoxP.Add(PlayerCard2);
                pictureBoxP.Add(PlayerCard3);
                pictureBoxP.Add(PlayerCard4);
                pictureBoxP.Add(PlayerCard5);
                pictureBoxP.Add(PlayerCard6);
                pictureBoxE.Add(DealerCard1);
                pictureBoxE.Add(DealerCard2);
                pictureBoxE.Add(DealerCard3);
                pictureBoxE.Add(DealerCard4);
                pictureBoxE.Add(DealerCard5);
                pictureBoxE.Add(DealerCard6);
            }
        }
        private void ShuffleClicked(object sender, EventArgs e)
        {
            CardShuffle();
            ShuffleCard.Enabled = false;
            CardRelease.Enabled = true;
        }

        private void VersionClicked(object sender, EventArgs e)
        {
            MessageBox.Show("1.00", "バージョン情報");
        }

        private void GameEndClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReleaseClicked(object sender, EventArgs e)
        {
            //list1 = player1.CardDistributePlayer(testBJ);
            //list2 = enemy.CardDistributeEnemy(testBJ);
            //list1 = player1.CardDistributePlayer(testSplit);
            //list2 = enemy.CardDistributeEnemy(testSplit);
            list1 = player1.CardDistributePlayer(shuffle);
            list2 = enemy.CardDistributeEnemy(shuffle);
            SumPointE = list2[0].Point;
            DealerPoint.Text = SumPointE.ToString() + "+ ??";
            //list1 = player1.CardDistributePlayer(testBJ);
            //list2 = enemy.CardDistributeEnemy(testBJ);
            //list1 = player1.CardDistributePlayer(testSplit);
            //list2 = enemy.CardDistributeEnemy(testSplit);
            list1 = player1.CardDistributePlayer(shuffle);
            list2 = enemy.CardDistributeEnemy(shuffle);
            pictureBoxE[enemySum - 1].ImageLocation = "image\\53.png";
            SumPointP = player1.CalcPlayerFirst(list1);
            if (SumPointP <= 20)
            {
                doubleDown.Enabled = true;
            }
            CardDraw.Enabled = true;
            CardJudge.Enabled = true;
            CardRelease.Enabled = false;
            player2.Play();
            BetButton1.Visible = true;
            Bet10Button.Visible = true;
            surrender.Enabled = true;
            if (list2[0].Number == 1)
            {
                insurance.Enabled = true;
                insurance10.Enabled = true;
                if (SumPointP == 21.5)
                {
                    EvenMoney.Enabled = true;
                }
            }
            if (list1[0].Point == list1[1].Point && list1[0].Point >= 4)
            {
                split.Enabled = true;
            }
        }

        private void CardDraw_Click(object sender, EventArgs e)
        {
            if (doubledown == "double")
            {
                list1 = player1.CardDrowPlayer(list1, shuffle);
                SumPointP = player1.CalcPlayer(list1);
                CardDraw.Enabled = false;
                surrender.Enabled = false;
                doubleDown.Enabled = false;
                CardJudge.Enabled = true;
            }
            else
            {
                list1 = player1.CardDrowPlayer(list1, shuffle);
                SumPointP = player1.CalcPlayer(list1);
                player2.Play();
                doubleDown.Enabled = false;
                surrender.Enabled = false;
            }
        }

        private void JudgeClicked(object sender, EventArgs e)
        {

            SumPointE = enemy.CardDrowEnemy(list2, shuffle);
            Console.WriteLine($"{SumPointP},{SumPointE}");
            enemy.BJJudge(SumPointP, SumPointE);
            Initialization.Enabled = true;
            CardDraw.Enabled = false;
            CardJudge.Enabled = false;
            EvenMoney.Enabled = false;
            Output.Enabled = true;
            insurance.Enabled = false;
            insurance10.Enabled = false;
            surrender.Enabled = false;
            doubleDown.Enabled = false;
        }

        private void Ticked(object sender, EventArgs e)
        {
            timer1.Stop();
            player.controls.play();// ポーズ(play()で再開)
        }
        public void Start()
        {
            timer1.Interval = 5000;
            timer1.Start();
        }
        public void Start2()
        {
            timer1.Interval = 10000;
            timer1.Start();
        }
        private void PlayStart()
        {
            player.controls.play();// ポーズ(play()で再開)

        }

        private void Initialization_Clicked(object sender, EventArgs e)
        {
            CardClear(list1, list2, cards, shuffle, splitlist1, splitlist2);
            pictureBoxP.Clear();
            pictureBoxE.Clear();
            splitpictureBoxP1.Clear();
            splitpictureBoxP2.Clear();
            sum = 0;
            playerSum = 0;
            PlayerPoint.Text = "0";
            enemySum = 0;
            DealerPoint.Text = "0";
            splitNumber1 = 1;
            splitNumber2 = 1;
            splitPoint = 3;
            splitCount1 = 0;
            splitCount2 = 0;
            PlayerCard1.Image = null;
            PlayerCard2.Image = null;
            PlayerCard3.Image = null;
            PlayerCard4.Image = null;
            PlayerCard5.Image = null;
            PlayerCard6.Image = null;
            DealerCard1.Image = null;
            DealerCard2.Image = null;
            DealerCard3.Image = null;
            DealerCard4.Image = null;
            DealerCard5.Image = null;
            DealerCard6.Image = null;
            NewGame.Enabled = true;
            Initialization.Enabled = false;
            WinOrLoseP.Visible = false;
            WinOrLoseE.Visible = false;
            CrownPictureP.Visible = false;
            CrownPictureE.Visible = false;
            if (coin == 0)
            {
                coin = 10;
                coinlabel.Text = coin.ToString();
            }
            bet = 0;

            Output.Enabled = false;
            Input.Enabled = true;
            BetButton1.Text = "BET";
            BetButton1.Visible = true;
            BetButton1.Enabled = true;
            Bet10Button.Text = "10BET";
            Bet10Button.Visible = true;
            if (coin >= 10)
            {
                Bet10Button.Enabled = true;
            }
            else
            {
                Bet10Button.Enabled = false;
            }
            insurance.Text = "insurance1";
            insBet = 0;
            insurance10.Text = "insurance10";
            SplitBetButton.Text = "スプリットBET";
            doubledown = null;
            PlayerPoint3.Text = "";
            PlayerPoint.Visible = true;
            PlayerPoint3.Visible = true;
            SplitPoint1.Visible = false;
            SplitPoint2.Visible = false;
        }


        private void BetButton1Clicked(object sender, EventArgs e)
        {
            if (coin < 10 && 0 < coin)
            {
                bet++;
                coin--;
                BetButton1.Text = bet.ToString();
                Bet10Button.Text = bet.ToString();
                coinlabel.Text = coin.ToString();
                Bet10Button.Enabled = false;
            }
            else if (coin <= 0)
            {
                BetButton1.Enabled = false;
                Bet10Button.Enabled = false;
            }
            else
            {
                bet++;
                coin--;
                BetButton1.Text = bet.ToString();
                Bet10Button.Text = bet.ToString();
                coinlabel.Text = coin.ToString();
            }
            if (coin <= 0)
            {
                BetButton1.Enabled = false;
                Bet10Button.Enabled = false;
            }

        }

        private void Output_Click(object sender, EventArgs e)
        {
            NameCoins nameCoins = new NameCoins();
            nameCoins.Coins = coin;
            nameCoins.Name = label2.Text;
            // オブジェクトからJSON文字列を作成（インデントフォーマットあり）
            string json = JsonSerializer.Serialize(nameCoins, options);
            // ファイルに出力

            File.WriteAllText("propaty.json", json);

        }

        private void Input_Click(object sender, EventArgs e)
        {
            NameCoins product = JsonFile();

            coin = product.Coins;
            if (coin == 0)
            {
                coin = 10;
                coinlabel.Text = coin.ToString();
            }
            else
            {
                coinlabel.Text = coin.ToString();
            }
            label2.Text = product.Name;
        }

        private void Bet10Button_Click(object sender, EventArgs e)
        {
            if (coin >= 10)
            {
                coin -= 10;
                bet += 10;
                coinlabel.Text = coin.ToString();
                BetButton1.Text = bet.ToString();
                Bet10Button.Text = bet.ToString();
                if (coin < 10)
                {
                    Bet10Button.Enabled = false;
                }
                else if (coin == 0)
                {
                    BetButton1.Enabled = false;
                }
            }

            else
            {
                if (coin <= 0)
                {
                    BetButton1.Enabled = false;
                    Bet10Button.Enabled = false;
                }
                else
                {
                    Bet10Button.Enabled = false;
                }
            }
            if (coin <= 0)
            {
                BetButton1.Enabled = false;
            }
        }

        private void NameInput_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("", "名前入力", "名前を入力してください", -1, -1);
            if (str == "")
            {
                label2.Text = label2.Text;
            }
            else
            {
                label2.Text = str;
            }

        }

        private void insurance_Click(object sender, EventArgs e)
        {
            if (insBet + 1 > bet / 2)
            {
                MessageBox.Show("賭けることができません");
            }
            else
            {
                if (coin > 0)
                {
                    insBet++;
                    coin--;
                    coinlabel.Text = coin.ToString();
                    insurance.Text = insBet.ToString();
                    insurance10.Text = insBet.ToString();
                }
                else
                {
                    MessageBox.Show("コインがありません");
                }
            }
        }

        private void insurance10_Click(object sender, EventArgs e)
        {
            if (insBet + 10 > bet / 2)
            {
                MessageBox.Show("賭けることができません");
            }
            else
            {

                if (coin > 9)
                {
                    insBet += 10;
                    coin -= 10;
                    coinlabel.Text = coin.ToString();
                    insurance.Text = insBet.ToString();
                    insurance10.Text = insBet.ToString();
                }
                else
                {
                    MessageBox.Show("コインがありません");
                }
            }
        }

        private void doubleDown_Click(object sender, EventArgs e)
        {
            if (bet < coin)
            {
                bet += bet;
                coin -= bet / 2;
                coinlabel.Text = coin.ToString();
                BetButton1.Text = bet.ToString();
                Bet10Button.Text = bet.ToString();
                doubledown = "double";
                doubleDown.Enabled = false;
                CardJudge.Enabled = false;

            }
            else
            {
                MessageBox.Show("コインが足りません");
            }
        }

        private void surrender_Click(object sender, EventArgs e)
        {
            coin += bet / 2;
            coinlabel.Text = coin.ToString();
            doubleDown.Enabled = false;
            surrender.Enabled = false;
            CardJudge.Enabled = false;
            Initialization.Enabled = true;
            CardDraw.Enabled = false;
            WinOrLoseP.ForeColor = Color.Purple;
            WinOrLoseP.Text = "サレンダー";
            WinOrLoseP.Visible = true;
        }

        private void split_Click(object sender, EventArgs e)
        {
            if (bet > coin)
            {
                MessageBox.Show("賭けられません");
                player1.AToChange(list1);
                SumPointP = 0;
                foreach (var test in list1)
                {
                    SumPointP += test.Point;
                }
                PlayerPoint.Text = SumPointP.ToString();
            }
            else
            {
                splitBet = bet;
                SplitBetButton.Text = splitBet.ToString();
                coin -= splitBet;
                coinlabel.Text = coin.ToString();
                pictureBoxP[0].Image = null;
                pictureBoxP[1].Image = null;
                pictureBoxP[2].Image = null;
                pictureBoxP[3].Image = null;
                pictureBoxP[4].Image = null;
                pictureBoxP[5].Image = null;

                splitpictureBoxP1.Add(PlayerCard1);
                splitpictureBoxP1.Add(PlayerCard2);
                splitpictureBoxP1.Add(PlayerCard3);
                splitpictureBoxP2.Add(PlayerCard4);
                splitpictureBoxP2.Add(PlayerCard5);
                splitpictureBoxP2.Add(PlayerCard6);
                splitlist1.Add(new Card(cards[sum].Suit, cards[sum].Number, cards[sum].Id, cards[sum].Point, cards[sum].Address));
                sum++;
                splitlist2.Add(new Card(cards[sum].Suit, cards[sum].Number, cards[sum].Id, cards[sum].Point, cards[sum].Address));
                splitlist1[0] = list1[0];
                splitlist2[0] = list1[1];
                splitpictureBoxP1[0].ImageLocation = splitlist1[0].Address;
                splitpictureBoxP2[0].ImageLocation = splitlist2[0].Address;

                split.Enabled = false;
                CardJudge.Enabled = false;
                Split1Draw1.Enabled = true;
                CardDraw.Enabled = false;
                doubleDown.Enabled = false;
                PlayerPoint.Visible = false;
                PlayerPoint3.Visible = false;
                SplitPoint1.Visible = true;
                SplitPoint2.Visible = true;
                SplitPoint1.Text = splitlist1[0].Point.ToString();
                SplitPoint2.Text = splitlist2[0].Point.ToString();
            }
        }

        private void Split1Draw1_Click(object sender, EventArgs e)
        {
            if (splitlist1[0].Number == 1)
            {
                splitlist1 = player1.CardDrowPlayerSplit(splitlist1, shuffle);
                SumPointP = player1.CalcPlayerFirstS(splitlist1);
                SumPointP = 0;
                for (int i = 0; i < splitlist1.Count; i++)
                {
                    SumPointP += splitlist1[i].Point;
                }
                if (SumPointP == 21)
                {
                    SumPointP += (float)0.5;
                    SplitPoint1.Text = "Black\nJack";
                }
                if (SumPointP <= 21)
                {
                    SplitPoint1.Text = SumPointP.ToString();
                }
                else if (SumPointP == 21.5) { }
                else
                {
                    SplitPoint1.Text = "Burst";
                }
                Split1Judge.Enabled = true;
                Split1Draw1.Enabled = false;
            }
            if (splitCount1 == 0 && splitlist1[0].Number != 1)
            {
                splitlist1 = player1.CardDrowPlayerSplit(splitlist1, shuffle);
                SumPointP = player1.CalcPlayerFirstS(splitlist1);
                SumPointP = 0;
                for (int i = 0; i < splitlist1.Count; i++)
                {
                    SumPointP += splitlist1[i].Point;
                }
                if (SumPointP <= 21)
                {
                    SplitPoint1.Text = SumPointP.ToString();
                }
                else
                {
                    SplitPoint1.Text = "Burst";
                }
                splitCount1++;
                Split1Judge.Enabled = true;
            }
            else if (splitCount1 == 1 && splitlist1[0].Number != 1)
            {
                splitlist1 = player1.CardDrowPlayerSplit(splitlist1, shuffle);
                SumPointP = player1.CalcPlayerFirstS(splitlist1);
                SumPointP = 0;
                for (int i = 0; i < splitlist1.Count; i++)
                {
                    SumPointP += splitlist1[i].Point;
                }
                if (SumPointP <= 21)
                {
                    SplitPoint1.Text = SumPointP.ToString();
                }
                else
                {
                    SplitPoint1.Text = "Burst";
                }
                Split1Draw1.Enabled = false;
                Split1Judge.Enabled = true;

            }
        }
        private void Split1Draw2_Click(object sender, EventArgs e)
        {
            if (splitlist2[0].Number == 1)
            {
                splitlist2 = player1.CardDrowPlayerSplit2(splitlist2, shuffle);
                SumPointP2 = player1.CalcPlayerFirstS(splitlist2);
                SumPointP2 = 0;
                for (int i = 0; i < splitlist2.Count; i++)
                {
                    SumPointP2 += splitlist2[i].Point;
                }
                if (SumPointP2 == 21)
                {
                    SumPointP2 += (float)0.5;
                    SplitPoint2.Text = "Black\nJack";
                }
                if (SumPointP2 <= 21)
                {
                    SplitPoint2.Text = SumPointP2.ToString();
                }
                else if (SumPointP2 == 21.5)
                {
                }
                else
                {
                    SplitPoint2.Text = "Burst";
                }
                Split2Judge.Enabled = true;
                SplitDraw2.Enabled = false;

            }
            if (splitCount2 == 0 && splitlist2[0].Number != 1)
            {
                splitlist2 = player1.CardDrowPlayerSplit2(splitlist2, shuffle);
                player1.CalcPlayer(splitlist2);
                SumPointP2 = 0;
                for (int i = 0; i < splitlist2.Count; i++)
                {
                    SumPointP2 += splitlist2[i].Point;
                }
                if (SumPointP2 <= 21)
                {
                    SplitPoint2.Text = SumPointP2.ToString();
                }
                splitCount2++;
                Split2Judge.Enabled = true;
            }
            else if (splitCount2 == 1 && splitlist2[0].Number != 1)
            {
                splitlist2 = player1.CardDrowPlayerSplit2(splitlist2, shuffle);
                SumPointP2 = player1.CalcPlayer(splitlist2);
                SumPointP2 = 0;
                for (int i = 0; i < splitlist2.Count; i++)
                {
                    SumPointP2 += splitlist2[i].Point;
                }
                if (SumPointP2 <= 21)
                {
                    SplitPoint2.Text = SumPointP2.ToString();
                }
                else if (SumPointP2 > 21)
                {
                    SplitPoint2.Text = "Burst";
                }
                Split2Judge.Enabled = true;
                SplitDraw2.Enabled = false;
            }
        }
        private void Split2Judge_Click(object sender, EventArgs e)
        {

            Split2Judge.Enabled = false;
            SumPointE = enemy.CardDrowEnemy(list2, shuffle);
            Console.WriteLine($"{SumPointP},{SumPointE}");
            enemy.BJJudgeS(SumPointP, SumPointP2, SumPointE);
            Initialization.Enabled = true;
            Output.Enabled = true;
            insurance.Enabled = false;
            insurance10.Enabled = false;
            surrender.Enabled = false;
            doubleDown.Enabled = false;
            SplitDraw2.Enabled = false;

        }
        private void Split1Judge_Click(object sender, EventArgs e)
        {
            Split1Draw1.Enabled = false;
            SplitDraw2.Enabled = true;
            Split1Judge.Enabled = false;
        }
        private void EvenMoney_Click(object sender, EventArgs e)
        {
            coin += bet * 2;
            coinlabel.Text = coin.ToString();
            WinOrLoseP.Visible = true;
            WinOrLoseP.ForeColor = System.Drawing.Color.Purple;
            WinOrLoseP.Text = "イーブン\nマネー";
            Initialization.Enabled = true;
            CardDraw.Enabled = false;
            CardJudge.Enabled = false;
            surrender.Enabled = false;

        }
        void CardCreate()
        {
            for (int i = 1; i < 14; i++)
            {
                cards.Add(new Card(CardSuit.Club, i, i, i, "image\\" + i + ".png"));
            }
            for (int i = 1; i < 14; i++)
            {
                cards.Add(new Card(CardSuit.Spade, i, i + 13, i, "image\\" + (i + 13) + ".png"));
            }
            for (int i = 1; i < 14; i++)
            {
                cards.Add(new Card(CardSuit.Heart, i, i + 26, i, "image\\" + (i + 26) + ".png"));
            }
            for (int i = 1; i < 14; i++)
            {
                cards.Add(new Card(CardSuit.Diamond, i, i + 39, i, "image\\" + (i + 39) + ".png"));
            }
            foreach (Card card in cards)
            {
                card.PointCount(card.Number);
                //Console.WriteLine($"{card.Suit}{card.Number} {card.Id} {card.Point} {card.Address}");
            }

        }
        Random random = new Random();
        void CardShuffle()
        {
            for (int i = 51; i >= 0; i--)
            {
                int num = random.Next(0, i + 1);
                shuffle.Add(new Card(cards[num].Suit, cards[num].Number, cards[num].Id, cards[num].Point, cards[num].Address));
                cards.RemoveAt(num);
            }
            cards = shuffle;
            foreach (var cardS in shuffle)
            {
                Console.WriteLine($"{cardS.Suit}{cardS.Number} {cardS.Id} {cardS.Point} {cardS.Address}");
            }
        }
        void CardClear(List<Card> list1, List<Card> list2, List<Card> cards, List<Card> shuffle, List<Card> splitlist1, List<Card> splitlist2)
        {
            list1.Clear();
            list2.Clear();
            cards.Clear();
            shuffle.Clear();
            splitlist1.Clear();
            splitlist2.Clear();
        }
        void TestBJ(List<Card> cards)
        {
            testBJ.Add(new Card(CardSuit.Club, 3, 3, 3, "image\\" + 3 + ".png"));
            testBJ.Add(new Card(CardSuit.Club, 1, 1, 11, "image\\" + 1 + ".png"));
            testBJ.Add(new Card(CardSuit.Club, 4, 4, 4, "image\\" + 4 + ".png"));
            testBJ.Add(new Card(CardSuit.Club, 11, 11, 10, "image\\" + 11 + ".png"));
        }
        void TestSplitA(List<Card> cards)
        {
            testSplit.Add(new Card(CardSuit.Club, 9, 9, 9, "image\\" + 9 + ".png"));
            testSplit.Add(new Card(CardSuit.Club, 11, 11, 10, "image\\" + 11 + ".png"));
            testSplit.Add(new Card(CardSuit.Spade, 9, 22, 9, "image\\" + 22 + ".png"));
            testSplit.Add(new Card(CardSuit.Club, 8, 8, 8, "image\\" + 8 + ".png"));
            testSplit.Add(new Card(CardSuit.Club, 10, 10, 10, "image\\" + 10 + ".png"));
            testSplit.Add(new Card(CardSuit.Club, 5, 5, 5, "image\\" + 5 + ".png"));
        }
        private NameCoins JsonFile()
        {
            string json = File.ReadAllText("propaty.json");

            NameCoins product = JsonSerializer.Deserialize<NameCoins>(json);
            return product;
        }
    }
    class NameCoins
    {
        public int Coins { get; set; }
        public string Name { get; set; }
    }
}
