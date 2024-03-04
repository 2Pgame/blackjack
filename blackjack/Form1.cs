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
            PlayerPoint.Parent = pictureBox0;
            DealerPoint.Parent = pictureBox0;
            PlayerPoint.Parent = pictureBox0;
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
        public List<PictureBox> pictureBoxP = new List<PictureBox>();
        public List<PictureBox> pictureBoxE = new List<PictureBox>();
        public int sum = 0;
        public int playerSum;
        public int enemySum;
        public int coin;
        public int bet;


        public float SumPointP;
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
            if (coin == 0)
            {
                coin = 10;
                coinlabel.Text = coin.ToString();
            }
            CardCreate();
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
        void CardClear(List<Card> list1, List<Card> list2, List<Card> cards, List<Card> shuffle)
        {
            list1.Clear();
            list2.Clear();
            cards.Clear();
            shuffle.Clear();
        }

        private void GameEndClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReleaseClicked(object sender, EventArgs e)
        {
            list1 = player1.CardDistributePlayer(shuffle);
            list2 = enemy.CardDistributeEnemy(shuffle);
            SumPointE = list2[0].Point;
            DealerPoint.Text = SumPointE.ToString() + "+ ??";
            list1 = player1.CardDistributePlayer(shuffle);
            list2 = enemy.CardDistributeEnemy(shuffle);
            pictureBoxE[enemySum - 1].ImageLocation = "image\\53.png";
            SumPointP = player1.CalcPlayerFirst(list1);
            CardDraw.Enabled = true;
            CardJudge.Enabled = true;
            CardRelease.Enabled = false;
            player2.Play();
            BetButton.Enabled = true;
            BetButton1.Visible = true;
            BetButton1.Enabled = true;
            Bet10Button.Visible = true;
            if (coin >= 10)
            {
                Bet10Button.Enabled = true;
            }
            else
            {
                Bet10Button.Enabled = false;
            }

        }

        private void CardDraw_Click(object sender, EventArgs e)
        {
            if (bet == 0)
            {
                MessageBox.Show("最低１枚かけてください");
            }
            else
            {
                list1 = player1.CardDrowPlayer(list1, shuffle);
                SumPointP = player1.CalcPlayer(list1);
                player2.Play();
            }

        }

        private void JudgeClicked(object sender, EventArgs e)
        {
            if (bet == 0)
            {
                MessageBox.Show("最低１枚かけてください");
            }
            else
            {
                SumPointE = enemy.CardDrowEnemy(list2, shuffle);
                Console.WriteLine($"{SumPointP},{SumPointE}");

                enemy.BJJudge(SumPointP, SumPointE);
                Initialization.Enabled = true;
                CardDraw.Enabled = false;
                CardJudge.Enabled = false;
                Output.Enabled = true;
            }
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
            CardClear(list1, list2, cards, shuffle);
            pictureBoxP.Clear();
            pictureBoxE.Clear();
            sum = 0;
            playerSum = 0;
            PlayerPoint.Text = "0";
            enemySum = 0;
            DealerPoint.Text = "0";
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
            BetButton1.Text = "BET";
            BetButton1.Visible = false;
            Bet10Button.Text = "10BET";
            Bet10Button.Visible = false;
            Output.Enabled = false;
            Input.Enabled = true;
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

            else
            {
                bet++;
                coin--;
                BetButton1.Text = bet.ToString();
                Bet10Button.Text = bet.ToString();
                coinlabel.Text = coin.ToString();
            }
            if (coin == 0)
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
            string json = File.ReadAllText("propaty.json");

            NameCoins product = JsonSerializer.Deserialize<NameCoins>(json);

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
                if (coin == 0)
                {
                    BetButton1.Enabled = false;
                    Bet10Button.Enabled = false;
                }
                else
                {
                    Bet10Button.Enabled = false;
                }
            }
        }

        private void NameInput_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("", "名前入力", "名前を入力してください", -1, -1);
            label2.Text = str;
        }
    }
    class NameCoins
    {
        public int Coins { get; set; }
        public string Name { get; set; }
    }
}
