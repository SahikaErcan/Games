
namespace HangmanGame
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.groupBoxWordList = new System.Windows.Forms.GroupBox();
            this.listBoxWord = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelWordAddDelete = new System.Windows.Forms.Panel();
            this.btnScoreTable = new System.Windows.Forms.Button();
            this.btnWordList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.listBoxScore = new System.Windows.Forms.ListBox();
            this.groupBoxLogin.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.groupBoxWordList.SuspendLayout();
            this.panelWordAddDelete.SuspendLayout();
            this.groupBoxScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdmin.Location = new System.Drawing.Point(48, 58);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(432, 88);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin Girişi";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackColor = System.Drawing.Color.White;
            this.btnPlayer.FlatAppearance.BorderSize = 0;
            this.btnPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPlayer.Location = new System.Drawing.Point(48, 147);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(432, 88);
            this.btnPlayer.TabIndex = 1;
            this.btnPlayer.Text = "Oyuncu Girişi";
            this.btnPlayer.UseVisualStyleBackColor = false;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.btnAdmin);
            this.groupBoxLogin.Controls.Add(this.btnPlayer);
            this.groupBoxLogin.Location = new System.Drawing.Point(1232, 138);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(527, 284);
            this.groupBoxLogin.TabIndex = 2;
            this.groupBoxLogin.TabStop = false;
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.groupBoxWordList);
            this.panelAdmin.Controls.Add(this.btnBack);
            this.panelAdmin.Controls.Add(this.panelWordAddDelete);
            this.panelAdmin.Controls.Add(this.groupBoxScore);
            this.panelAdmin.Location = new System.Drawing.Point(12, 12);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(1164, 543);
            this.panelAdmin.TabIndex = 5;
            this.panelAdmin.Visible = false;
            // 
            // groupBoxWordList
            // 
            this.groupBoxWordList.Controls.Add(this.listBoxWord);
            this.groupBoxWordList.ForeColor = System.Drawing.Color.White;
            this.groupBoxWordList.Location = new System.Drawing.Point(725, 575);
            this.groupBoxWordList.Name = "groupBoxWordList";
            this.groupBoxWordList.Size = new System.Drawing.Size(325, 471);
            this.groupBoxWordList.TabIndex = 10;
            this.groupBoxWordList.TabStop = false;
            this.groupBoxWordList.Text = "Kelime Listesi";
            // 
            // listBoxWord
            // 
            this.listBoxWord.FormattingEnabled = true;
            this.listBoxWord.ItemHeight = 25;
            this.listBoxWord.Location = new System.Drawing.Point(19, 42);
            this.listBoxWord.Name = "listBoxWord";
            this.listBoxWord.Size = new System.Drawing.Size(285, 404);
            this.listBoxWord.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(1116, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 47);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelWordAddDelete
            // 
            this.panelWordAddDelete.Controls.Add(this.btnScoreTable);
            this.panelWordAddDelete.Controls.Add(this.btnWordList);
            this.panelWordAddDelete.Controls.Add(this.label1);
            this.panelWordAddDelete.Controls.Add(this.btnDelete);
            this.panelWordAddDelete.Controls.Add(this.btnAdd);
            this.panelWordAddDelete.Controls.Add(this.txtWord);
            this.panelWordAddDelete.Location = new System.Drawing.Point(90, 61);
            this.panelWordAddDelete.Name = "panelWordAddDelete";
            this.panelWordAddDelete.Size = new System.Drawing.Size(542, 429);
            this.panelWordAddDelete.TabIndex = 7;
            // 
            // btnScoreTable
            // 
            this.btnScoreTable.BackColor = System.Drawing.Color.White;
            this.btnScoreTable.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnScoreTable.Location = new System.Drawing.Point(45, 355);
            this.btnScoreTable.Name = "btnScoreTable";
            this.btnScoreTable.Size = new System.Drawing.Size(360, 61);
            this.btnScoreTable.TabIndex = 7;
            this.btnScoreTable.Text = "SKOR TABLOSU";
            this.btnScoreTable.UseVisualStyleBackColor = false;
            this.btnScoreTable.Click += new System.EventHandler(this.btnScoreTable_Click);
            // 
            // btnWordList
            // 
            this.btnWordList.BackColor = System.Drawing.Color.White;
            this.btnWordList.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnWordList.Location = new System.Drawing.Point(45, 288);
            this.btnWordList.Name = "btnWordList";
            this.btnWordList.Size = new System.Drawing.Size(360, 61);
            this.btnWordList.TabIndex = 6;
            this.btnWordList.Text = "KELİME LİSTESİ";
            this.btnWordList.UseVisualStyleBackColor = false;
            this.btnWordList.Click += new System.EventHandler(this.btnWordList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Oyuna eklemek/çıkarmak istediğiniz kelimeyi giriniz...";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.Location = new System.Drawing.Point(45, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(360, 61);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Enabled = false;
            this.btnAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.Location = new System.Drawing.Point(45, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(360, 61);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtWord
            // 
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWord.Location = new System.Drawing.Point(45, 67);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(360, 38);
            this.txtWord.TabIndex = 0;
            this.txtWord.Enter += new System.EventHandler(this.txtWord_Enter);
            // 
            // groupBoxScore
            // 
            this.groupBoxScore.Controls.Add(this.listBoxScore);
            this.groupBoxScore.ForeColor = System.Drawing.Color.White;
            this.groupBoxScore.Location = new System.Drawing.Point(725, 41);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.Size = new System.Drawing.Size(325, 474);
            this.groupBoxScore.TabIndex = 6;
            this.groupBoxScore.TabStop = false;
            this.groupBoxScore.Text = "Skor Tablosu";
            // 
            // listBoxScore
            // 
            this.listBoxScore.FormattingEnabled = true;
            this.listBoxScore.ItemHeight = 25;
            this.listBoxScore.Location = new System.Drawing.Point(19, 45);
            this.listBoxScore.Name = "listBoxScore";
            this.listBoxScore.Size = new System.Drawing.Size(285, 404);
            this.listBoxScore.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1186, 566);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.groupBoxLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBoxLogin.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.groupBoxWordList.ResumeLayout(false);
            this.panelWordAddDelete.ResumeLayout(false);
            this.panelWordAddDelete.PerformLayout();
            this.groupBoxScore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelWordAddDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.ListBox listBoxScore;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnWordList;
        private System.Windows.Forms.Button btnScoreTable;
        public System.Windows.Forms.GroupBox groupBoxWordList;
        public System.Windows.Forms.ListBox listBoxWord;
    }
}

