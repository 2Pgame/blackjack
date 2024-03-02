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

namespace blackjack
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
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
            player.URL = @"カジノ ドラクエ4BGM.wav";
            player.controls.play();
            //背景にカジノを使う
            pictureBox0.ImageLocation = "image\\cajino.png";
            pictureBox11.ImageLocation = "image\\coin.png";
            pictureBox11.Parent = pictureBox0;
            PlayerPoint.Parent = pictureBox0;
            DealerPoint.Parent = pictureBox0;
            pictureBoxP.Add(PlayerCard1);
            pictureBoxP.Add(PlayerCard2);
            pictureBoxP.Add(PlayerCard3);
            pictureBoxP.Add(PlayerCard4);
            pictureBoxP.Add(PlayerCard5);
            pictureBoxE.Add(DealerCard1);
            pictureBoxE.Add(DealerCard2);
            pictureBoxE.Add(DealerCard3);
            pictureBoxE.Add(DealerCard4);
            pictureBoxE.Add(DealerCard5);
            PlayerCard1.Parent = pictureBox0;
            PlayerCard2.Parent = pictureBox0;
            PlayerCard3.Parent = pictureBox0;
            PlayerCard4.Parent = pictureBox0;
            PlayerCard5.Parent = pictureBox0;
            DealerCard1.Parent = pictureBox0;
            DealerCard2.Parent = pictureBox0;
            DealerCard3.Parent = pictureBox0;
            DealerCard4.Parent = pictureBox0;
            DealerCard5.Parent = pictureBox0;
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


        private float SumPointP;
        private float SumPointE;

        private void NewGameClicked(object sender, EventArgs e)
        {
            CardCreate();
            ShuffleCard.Enabled = true;
            NewGame.Enabled = false;
        }
        private void ShuffleClicked(object sender, EventArgs e)
        {
            CardShuffle();
            ShuffleCard.Enabled = false;
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
        void CardClear(List<Card> list, List<Card> shuffle)
        {
            list.Clear();
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
            pictureBoxE[enemySum-1].ImageLocation = "image\\53.png";
            SumPointP = player1.CalcPlayer(list1);
        }
        
        private void CardDraw_Click(object sender, EventArgs e)
        {
            list1 = player1.CardDrowPlayer(list1, shuffle);
            SumPointP = player1.CalcPlayer(list1);
        }

        private void JudgeClicked(object sender, EventArgs e)
        {
            SumPointE = enemy.CardDrowEnemy(list2, shuffle);
            Console.WriteLine($"{SumPointP},{SumPointE}");

            enemy.BJJudge(SumPointP, SumPointE);
        }
    }

}
