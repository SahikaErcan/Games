
namespace HangmanGame
{
    partial class LoginGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGame));
            this.groupBoxStartGame = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.checkBoxRandomNumber = new System.Windows.Forms.CheckBox();
            this.cmbLetterNumber = new System.Windows.Forms.ComboBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblFoundWord = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGuessLetters = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRightToTry = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxStartGame.SuspendLayout();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStartGame
            // 
            this.groupBoxStartGame.Controls.Add(this.label1);
            this.groupBoxStartGame.Controls.Add(this.txtName);
            this.groupBoxStartGame.Controls.Add(this.checkBoxRandomNumber);
            this.groupBoxStartGame.Controls.Add(this.cmbLetterNumber);
            this.groupBoxStartGame.Controls.Add(this.btnStartGame);
            this.groupBoxStartGame.Location = new System.Drawing.Point(1238, 109);
            this.groupBoxStartGame.Name = "groupBoxStartGame";
            this.groupBoxStartGame.Size = new System.Drawing.Size(477, 381);
            this.groupBoxStartGame.TabIndex = 7;
            this.groupBoxStartGame.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kelime uzunluğunu seçiniz...";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(48, 56);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(383, 50);
            this.txtName.TabIndex = 1;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // checkBoxRandomNumber
            // 
            this.checkBoxRandomNumber.AutoSize = true;
            this.checkBoxRandomNumber.ForeColor = System.Drawing.Color.White;
            this.checkBoxRandomNumber.Location = new System.Drawing.Point(116, 216);
            this.checkBoxRandomNumber.Name = "checkBoxRandomNumber";
            this.checkBoxRandomNumber.Size = new System.Drawing.Size(243, 29);
            this.checkBoxRandomNumber.TabIndex = 2;
            this.checkBoxRandomNumber.Text = "Rastgele Bir Sayı Seç";
            this.checkBoxRandomNumber.UseVisualStyleBackColor = true;
            this.checkBoxRandomNumber.CheckedChanged += new System.EventHandler(this.checkBoxRandomNumber_CheckedChanged);
            // 
            // cmbLetterNumber
            // 
            this.cmbLetterNumber.DropDownHeight = 115;
            this.cmbLetterNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLetterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbLetterNumber.FormattingEnabled = true;
            this.cmbLetterNumber.IntegralHeight = false;
            this.cmbLetterNumber.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbLetterNumber.Location = new System.Drawing.Point(48, 167);
            this.cmbLetterNumber.Name = "cmbLetterNumber";
            this.cmbLetterNumber.Size = new System.Drawing.Size(383, 33);
            this.cmbLetterNumber.TabIndex = 0;
            this.cmbLetterNumber.SelectedIndexChanged += new System.EventHandler(this.cmbLetterNumber_SelectedIndexChanged);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.White;
            this.btnStartGame.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnStartGame.Location = new System.Drawing.Point(48, 269);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(383, 70);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "BAŞLA";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelGame.Controls.Add(this.txtGuess);
            this.panelGame.Controls.Add(this.btnGuess);
            this.panelGame.Controls.Add(this.lblFoundWord);
            this.panelGame.Controls.Add(this.lblWord);
            this.panelGame.Controls.Add(this.btnBack);
            this.panelGame.Controls.Add(this.lblScore);
            this.panelGame.Controls.Add(this.label6);
            this.panelGame.Controls.Add(this.label3);
            this.panelGame.Controls.Add(this.lblGuessLetters);
            this.panelGame.Controls.Add(this.label4);
            this.panelGame.Controls.Add(this.pictureBox8);
            this.panelGame.Controls.Add(this.pictureBox4);
            this.panelGame.Controls.Add(this.pictureBox7);
            this.panelGame.Controls.Add(this.pictureBox3);
            this.panelGame.Controls.Add(this.pictureBox6);
            this.panelGame.Controls.Add(this.pictureBox2);
            this.panelGame.Controls.Add(this.pictureBox5);
            this.panelGame.Controls.Add(this.pictureBox1);
            this.panelGame.Controls.Add(this.lblRightToTry);
            this.panelGame.Controls.Add(this.label2);
            this.panelGame.ForeColor = System.Drawing.Color.White;
            this.panelGame.Location = new System.Drawing.Point(4, 1);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1176, 566);
            this.panelGame.TabIndex = 15;
            this.panelGame.Visible = false;
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuess.Location = new System.Drawing.Point(90, 324);
            this.txtGuess.Multiline = true;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(300, 55);
            this.txtGuess.TabIndex = 34;
            this.txtGuess.TextChanged += new System.EventHandler(this.txtGuess_TextChanged);
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.White;
            this.btnGuess.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuess.Location = new System.Drawing.Point(396, 324);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(200, 55);
            this.btnGuess.TabIndex = 33;
            this.btnGuess.Text = "Uygula";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblFoundWord
            // 
            this.lblFoundWord.AutoSize = true;
            this.lblFoundWord.Location = new System.Drawing.Point(944, 377);
            this.lblFoundWord.Name = "lblFoundWord";
            this.lblFoundWord.Size = new System.Drawing.Size(164, 25);
            this.lblFoundWord.TabIndex = 32;
            this.lblFoundWord.Text = "Aranılan Kelime";
            this.lblFoundWord.Visible = false;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWord.Location = new System.Drawing.Point(78, 164);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(217, 69);
            this.lblWord.TabIndex = 31;
            this.lblWord.Text = "_ _ _ _";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(1130, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 47);
            this.btnBack.TabIndex = 30;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(591, 75);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(24, 25);
            this.lblScore.TabIndex = 29;
            this.lblScore.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "SKOR: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kelimeyi direk tahmin edebilme hakkına sahipsiniz...";
            // 
            // lblGuessLetters
            // 
            this.lblGuessLetters.AutoSize = true;
            this.lblGuessLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuessLetters.Location = new System.Drawing.Point(283, 479);
            this.lblGuessLetters.Name = "lblGuessLetters";
            this.lblGuessLetters.Size = new System.Drawing.Size(69, 29);
            this.lblGuessLetters.TabIndex = 26;
            this.lblGuessLetters.Text = "____";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(56, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kullanılan Harfler:";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(1025, 271);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(38, 72);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 24;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1010, 203);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 72);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(960, 271);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(52, 67);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(928, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(168, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1025, 207);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(923, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(922, 205);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(90, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(793, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblRightToTry
            // 
            this.lblRightToTry.AutoSize = true;
            this.lblRightToTry.Location = new System.Drawing.Point(281, 75);
            this.lblRightToTry.Name = "lblRightToTry";
            this.lblRightToTry.Size = new System.Drawing.Size(24, 25);
            this.lblRightToTry.TabIndex = 16;
            this.lblRightToTry.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kalan Tahmin Hakkı :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(1238, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 54);
            this.listBox1.TabIndex = 33;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginGame
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1192, 579);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.groupBoxStartGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoginGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginGame_Load);
            this.groupBoxStartGame.ResumeLayout(false);
            this.groupBoxStartGame.PerformLayout();
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox checkBoxRandomNumber;
        private System.Windows.Forms.ComboBox cmbLetterNumber;
        private System.Windows.Forms.Button btnStartGame;
        public System.Windows.Forms.GroupBox groupBoxStartGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGuessLetters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRightToTry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblFoundWord;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}