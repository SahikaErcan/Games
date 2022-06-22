using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingPicturesGame
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        string text1 = "1. Oyuncu";
        string text2 = "2. Oyuncu";

        private void Start_Load(object sender, EventArgs e)
        {
            txtPlayer1.Text = text1;
            txtPlayer2.Text = text2;
            txtPlayer1.ForeColor = Color.Gray;
            txtPlayer2.ForeColor = Color.Gray;
        }

        private void txtPlayer1_Enter(object sender, EventArgs e)
        {
            if (txtPlayer1.Text == text1)
            {
                txtPlayer1.Text = "";
                txtPlayer1.ForeColor = Color.Black;
            }
        }

        private void txtPlayer1_Leave(object sender, EventArgs e)
        {
            if (txtPlayer1.Text == "")
            {
                txtPlayer1.Text = text1;
                txtPlayer1.ForeColor = Color.Gray;
            }
        }

        private void txtPlayer2_Enter(object sender, EventArgs e)
        {
            if (txtPlayer2.Text == text2)
            {
                txtPlayer2.Text = "";
                txtPlayer2.ForeColor = Color.Black;
            }
        }

        private void txtPlayer2_Leave(object sender, EventArgs e)
        {
            if (txtPlayer2.Text == "")
            {
                txtPlayer2.Text = text2;
                txtPlayer2.ForeColor = Color.Gray;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MatchingGame matchingGame = new MatchingGame();
            matchingGame.Show();
           // matchingGame.mixPictures();
            matchingGame.lblPlayer1.Text = txtPlayer1.Text;
            matchingGame.lblPlayer2.Text = txtPlayer2.Text;
            this.Hide();
        }
    }
}
