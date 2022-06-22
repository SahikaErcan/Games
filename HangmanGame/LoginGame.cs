using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class LoginGame : Form
    {
        string filePath = @"C:\Users\Excalibur\Desktop\Games\HangmanGame\bin\Debug\Words.txt";
        string scoreFilePath = @"C:\Users\Excalibur\Desktop\Games\HangmanGame\bin\Debug\Score.txt";

        public LoginGame()
        {
            InitializeComponent();
            txtName.Text = userName;
            txtName.ForeColor = Color.DarkGray;
        }
        private void LoginGame_Load(object sender, EventArgs e)
        {
            // We read in the listbox to find the words.
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
                streamReader.Close();
            }

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
        }

        int wordLength = 3, live;
        double picturePart = 0, score = 0;
        string userName = "Kullanıcı adınızı giriniz...";

        Random random = new Random();
        Login login = new Login();
        ArrayList words = new ArrayList();
        string[] foundLetters;

        void scoreTable()
        {
            StreamWriter streamWriter = new StreamWriter(scoreFilePath, true);
            streamWriter.WriteLine(txtName.Text + "\t" + lblScore.Text);
            streamWriter.Close();
        }

        string findWord()
        {
            foreach (string item in listBox1.Items)
            {
                if (item.Length == wordLength)
                {
                    words.Add(item);
                }
            }
            int number = random.Next(words.Count);
            return words[number].ToString();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == userName)
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = userName;
                txtName.ForeColor = Color.DarkGray;
            }
        }

        void playGround()
        {
            groupBoxStartGame.Location = new Point(1238, 109);
            panelGame.Visible = true;

            lblGuessLetters.Text = "";

            // determining the number of lives
            wordLength = lblFoundWord.Text.Length;
            live = wordLength + 2;
            lblRightToTry.Text = live.ToString();

            // initially "_" add till word finish
            foundLetters = new string[wordLength];
            lblWord.Text = "";
            for (int i = 0; i < wordLength; i++)
            {
                foundLetters[i] = "_ ";
                lblWord.Text += foundLetters[i].ToString();
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (txtName.Text == userName)
            {
                errorProvider1.SetError(txtName, "İsim alanını boş bırakmayınız.");
            }
            else if (cmbLetterNumber.SelectedItem == null)
            {
                if (checkBoxRandomNumber.Checked)
                {
                    wordLength = random.Next(3, 8);
                    lblFoundWord.Text = findWord();

                    playGround();
                }
                else
                {
                    errorProvider1.SetError(cmbLetterNumber, "Bir kelime uzunluğu seçiniz.");
                }

            }
            else
            {
                playGround();
            }
        }

        /* if it is going to be a random selection, it also ensures that it does not 
         * choose from the comboBox. */
        private void checkBoxRandomNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRandomNumber.Checked == true)
            {
                cmbLetterNumber.Enabled = false;
            }
            else
            {
                cmbLetterNumber.Enabled = true;
            }
        }

        private void cmbLetterNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbLetterNumber.Enabled == true)
            if (cmbLetterNumber.SelectedItem != null)
            {
                checkBoxRandomNumber.Enabled = false;
                wordLength = Convert.ToInt32(cmbLetterNumber.SelectedItem.ToString());
                lblFoundWord.Text = findWord();
            }
            else
            {
                checkBoxRandomNumber.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }

        void knowRight(bool knowTrue)
        {
            if (knowTrue == false)
            {
                if (live > 0)
                {
                    live--;
                    lblRightToTry.Text = live.ToString();
                    picturePart += (8.0 / wordLength);  // Since there are 8 pictures
                    picturePartShow(picturePart);
                    if (live == 0)
                    {
                        txtGuess.Enabled = false;
                        btnGuess.Enabled = false;
                        MessageBox.Show("KAYBETTİNİZ...\nAranılan Kelime: " + lblFoundWord.Text);
                        scoreTable();
                        login.Show();
                        this.Hide();
                    }
                }
            }
        }

        void picturePartShow(double picturePart)
        {
            if (picturePart >= 1)
            {
                pictureBox1.Visible = true;
                if (picturePart >= 2)
                {
                    pictureBox2.Visible = true;
                    if (picturePart >= 3)
                    {
                        pictureBox3.Visible = true;
                        if (picturePart >= 4)
                        {
                            pictureBox4.Visible = true;
                            if (picturePart >= 5)
                            {
                                pictureBox5.Visible = true;
                                if (picturePart >= 6)
                                {
                                    pictureBox6.Visible = true;
                                    if (picturePart >= 7)
                                    {
                                        pictureBox7.Visible = true;
                                        if (picturePart >= 8)
                                        {
                                            pictureBox8.Visible = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
            txtGuess.Text = txtGuess.Text.ToUpper();
            txtGuess.SelectionStart = txtGuess.Text.Length; //move cursor to end
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {           
            bool knowTrue = false;
            string wordEnter = txtGuess.Text.ToUpper().Trim();

            lblGuessLetters.Text += wordEnter;

            if (string.IsNullOrEmpty(wordEnter) && string.IsNullOrWhiteSpace(wordEnter))
            {
                MessageBox.Show("Boş değer girmeye çalışıyorsunuz.");
            }
            else
            {
                if (wordEnter == lblFoundWord.Text)  // if found right away
                {
                    lblWord.Text = "";  // text cleared
                    for (int i = 0; i < wordLength; i++)
                    {
                        lblWord.Text += wordEnter[i] + " "; // fill in text                      
                    }
                    lblScore.Text = "100";
                    MessageBox.Show("Tebrikler... Kazandınız.");
                    scoreTable();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    lblWord.Text = "";

                    // If the entered word is incorrect but the first letter is correct, get the first letter
                    for (int i = 0; i < wordLength; i++)
                    {
                        if (wordEnter[0] == lblFoundWord.Text[i])
                        {
                            foundLetters[i] = wordEnter[0] + " ";
                            knowTrue = true;
                            score += (100 / wordLength);
                            lblScore.Text = score.ToString();
                        }
                    }

                    // If the entered word is correct
                    if (foundLetters.Contains("_ ") == false)
                    {
                        MessageBox.Show("Tebrikler... Kazandınız.");
                        scoreTable();
                        login.Show();
                        this.Hide();
                    }
                    knowRight(knowTrue);

                    for (int j = 0; j < wordLength; j++)
                    {
                        lblWord.Text += foundLetters[j];
                    }
                    txtGuess.Clear();
                    txtGuess.Focus();
                }
            }
        }
    }
}
