using System;
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
    public partial class Login : Form
    {
        string filePath = @"C:\Users\Excalibur\Desktop\Games\HangmanGame\bin\Debug\Words.txt";
        string scoreFilePath = @"C:\Users\Excalibur\Desktop\Games\HangmanGame\bin\Debug\Score.txt";

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            groupBoxLogin.Location = new Point(324, 138);

            // score list
            using (StreamReader stream = new StreamReader(scoreFilePath))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    listBoxScore.Items.Add(line);
                }
                stream.Close();
            }

            // word list
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string line;
                // continues to read line by line until the line is blank
                while ((line = streamReader.ReadLine()) != null) 
                {
                    listBoxWord.Items.Add(line);
                }
                streamReader.Close();
            }

        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            LoginGame login = new LoginGame();
            login.Show();
            login.groupBoxStartGame.Location = new Point(332, 75);
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            groupBoxLogin.Location = new Point(1232, 138);
            panelAdmin.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            groupBoxLogin.Location = new Point(324, 138);
            panelAdmin.Visible = false;
        }

        private void btnWordList_Click(object sender, EventArgs e)
        {
            groupBoxScore.Location = new Point(725, 560);
            groupBoxWordList.Location = new Point(725, 41);
        }

        private void btnScoreTable_Click(object sender, EventArgs e)
        {
            groupBoxWordList.Location = new Point(725, 560);
            groupBoxScore.Location = new Point(725, 41);
        }

        // Adding words to the file
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtWord.Text == "")
            {
                btnAdd.Enabled = false;
            }
            else
            {
                // StreamWriter streamWriter = File.AppendText(filePath);
                // true --> AppendText
                StreamWriter streamWriter = new StreamWriter(filePath, true); 
                streamWriter.WriteLine(txtWord.Text.ToUpper().Trim());
                streamWriter.Close();

                listBoxWord.Items.Add(txtWord.Text.ToUpper().Trim());
                txtWord.Clear();
                txtWord.Focus();
            }
        }

        private void txtWord_Enter(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBoxWord.Items.Remove(listBoxWord.SelectedItem);

            // print existing data in list box to file
            StreamWriter streamWriter = new StreamWriter(filePath);
            foreach (string line in listBoxWord.Items)
            {
                streamWriter.WriteLine(line);
            }
            streamWriter.Close();
        }
    }
}
