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
    public partial class MatchingGame : Form
    {
        public MatchingGame()
        {
            InitializeComponent();
            timerChoose.Interval = 900;
            timerStart.Interval = 1600;
        }

        Button firstButton, button;
        int firstIndex, btnNumber, found = 0, startCounter = 3, counter = 0, player = 1, player1score = 0, player2score = 0;
        Random random = new Random();

        Start start = new Start();

        // fotograflar
        Image[] images = {
            Properties.Resources._1,
            Properties.Resources._2,
            Properties.Resources._3,
            Properties.Resources._4,
            Properties.Resources._5,
            Properties.Resources._6,
            Properties.Resources._7,
            Properties.Resources._8
        };

        // her fotoğraftan 2 tane var indisler belirleyip dizide tutuyoruz.
        int[] indexes = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
        // indexleri karıştırıyoruz.
        public void mixPictures()
        {
            // karıştır
            for (int i = 0; i < 16; i++)
            {
                int number = random.Next(16);

                int temp = indexes[i];
                indexes[i] = indexes[number];
                indexes[number] = temp;
            }

            // ve göster
            foreach (Button btn in panel1.Controls)
            {
                int btnNum = Convert.ToInt32(btn.Name.Substring(6));
                btn.Image = images[indexes[btnNum - 1]];
            }
        }

        private void MatchingGame_Load(object sender, EventArgs e)
        {
            timerStart.Enabled = true;
            mixPictures();

            label4.Text = "İyi gözlemle kısa bir süre sonra kartlar kapanacak !!!";
            lblPlayer.Visible = false;

            player++;
            playerQueue();
        }

        void gameFinish()
        {
            if (found == 8)
            {
                if (Convert.ToInt32(lblPlusScorePlayer1.Text) > Convert.ToInt32(lblPlusScorePlayer2.Text))
                {
                    MessageBox.Show("Tebrikler " + lblPlayer1.Text + " oyunu " + lblPlusScorePlayer1.Text + " puan ile kazandın...");
                }
                else if (Convert.ToInt32(lblPlusScorePlayer2.Text) > Convert.ToInt32(lblPlusScorePlayer1.Text))
                {
                    MessageBox.Show("Tebrikler " + lblPlayer2.Text + " oyunu " + lblPlusScorePlayer2.Text + " puan ile kazandın...");
                }
                else
                {
                    MessageBox.Show("Berabere kaldınız çocuklar mücadeleye devam...");
                }

                found = 0;

                foreach (Control control in Controls) // Controls listesi forma eklenen denetimleri tutar.
                {
                    control.Visible = true;
                }
                start.Show(); // başlangıç ekranına geri dön
                this.Hide();
            }
        }

        // başlangıçta kutuların hepsi bir kaç saniye görünsün ve kapansın
        private void timerStart_Tick(object sender, EventArgs e)
        {
            startCounter--;
            label5.Text = startCounter.ToString();
            if (startCounter == 0)
            {
                label5.Text = " ";
                label5.Visible = false;
                foreach (Button btn in panel1.Controls)
                {
                    btn.Image = null;
                    label4.Visible = false;
                    lblPlayer.Visible = true;
                    lblPlayer.Text = lblPlayer1.Text;
                }
            }
        }

        // seçim süresi
        private void timerChoose_Tick(object sender, EventArgs e)
        {
            counter = Convert.ToInt32(lblChooseTime.Text);
            counter--;
            lblChooseTime.Text = counter.ToString();

            if (counter == 0)
            {
                firstButton.Image = null;
                firstButton = null;
                timerChoose.Enabled = false;
                lblChooseTime.Text = "3";
                player++;
                playerQueue();
            }
        }

        void playerQueue()
        {
            if (player % 2 == 0) // oyun sırası 1. oyuncu da
            {
                lblPlayer.Text = lblPlayer1.Text;
                panelPlayer1.BackColor = Color.DarkGoldenrod; // 1. oyuncu kararır
                panelPlayer2.BackColor = Color.Goldenrod;
            }
            else  // oyun sırası 2. oyuncu da
            {
                lblPlayer.Text = lblPlayer2.Text;
                panelPlayer1.BackColor = Color.Goldenrod;
                panelPlayer2.BackColor = Color.DarkGoldenrod; // 2. oyuncu kararır.                   
            }
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            timerChoose.Enabled = true;

            // butona ulaşıyoruz. Hangi kutuya tıklandığını anlıyoruz.
            button = (Button)sender; 
            // seçilen butonların numaralarını alıyoruz.
            btnNumber = Convert.ToInt32(button.Name.Substring(6));
            // index dizisinde buton numarasının olduğu indexdeki değeri alıyoruz
            int indexNo = indexes[btnNumber - 1];
            // aldığımız index dizisindeki değere karşılık gelen resmi seçtiğimiz butona atıyoruz.
            button.Image = images[indexNo];
            // resimleri hızlı bir şekilde tekrar çizdiriyor gecikmeleri önlüyor.
            button.Refresh(); 


            if (firstButton == null) // Başlangıçta
            { //  ilk kutu işlemi
                firstButton = button;
                firstIndex = indexNo;
            }
            else if (firstButton == button)  // 1.buton ile ikinci buton aynı buton ise
            {
                timerChoose.Enabled = false;
                counter = 3;
                lblChooseTime.Text = "3";

                MessageBox.Show("Aynı kutuyu tekrar açamazsınız. Farklı bir kutu seçin...");
                firstButton.Image = null;
                firstButton = null;
                button.Image = null;
                button = null;
                player++;  // oyuncu değişikliği yap
                playerQueue();
            }
            else  // iki farklı buton seçilmiş ise
            {
                // kutular eşitse bekle ve yeni kutu seçilince kaldığın yerden devam et
                // (zaman güncellemesi yoksa)
                timerChoose.Enabled = false; 

                // ikinci kutu işlemi
                System.Threading.Thread.Sleep(1000); // 1 saniye bekletiyoruz.

                // kutuları kapatıyoruz.
                firstButton.Image = null;
                button.Image = null;


                if (firstIndex == indexNo)  // ilk kutu ile ikinci kutu indexi eşit ise
                {
                    found++; // bulunan sayısını 1 arttırıyoruz.                   

                    if (panelPlayer1.BackColor == Color.DarkGoldenrod)
                    {
                        player1score += 1;
                        lblPlusScorePlayer1.Text = player1score.ToString();
                    }
                    else
                    {
                        player2score += 1;
                        lblPlusScorePlayer2.Text = player2score.ToString();
                    }

                    // kutuları kapatıyoruz
                    firstButton.Visible = false;  // ilk kutu
                    button.Visible = false;       // ikinci kutu

                    gameFinish();
                }
                else
                {
                    // farklı kutu mu seçtin sayacı başa döndür.
                    counter = 3;
                    lblChooseTime.Text = "3";

                    // bulamadığı için oyuncu değişikliği
                    player++;
                    playerQueue();
                }
                firstButton = null; // ilk kutu güncellensin diye her adımda null yapıyoruz.
            }
        }
    }
}

