using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }
        List<Card> cards = new List<Card>();
        List<Card> shuffle = new List<Card>();
        private void NewGameClicked(object sender, EventArgs e)
        {
            CardCreate();
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
                Console.WriteLine($"{card.Suit}{card.Number} {card.Id} {card.Point} {card.Address}");
            }
        }

        private void VersionClicked(object sender, EventArgs e)
        {
            MessageBox.Show("1.00", "バージョン情報");
        }
    }

}
