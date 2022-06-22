
namespace MatchingPicturesGame
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(621, 425);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(218, 140);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(259, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1160, 147);
            this.label1.TabIndex = 1;
            this.label1.Text = "RESİM  EŞLEŞTİRME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(407, 685);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(797, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eşleşen resimleri ortaya çıkarmak için bir çift kutucuğa dokununuz...";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(505, 302);
            this.txtPlayer1.Multiline = true;
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(441, 50);
            this.txtPlayer1.TabIndex = 3;
            this.txtPlayer1.Enter += new System.EventHandler(this.txtPlayer1_Enter);
            this.txtPlayer1.Leave += new System.EventHandler(this.txtPlayer1_Leave);
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(505, 369);
            this.txtPlayer2.Multiline = true;
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(441, 50);
            this.txtPlayer2.TabIndex = 4;
            this.txtPlayer2.Enter += new System.EventHandler(this.txtPlayer2_Enter);
            this.txtPlayer2.Leave += new System.EventHandler(this.txtPlayer2_Leave);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(1454, 803);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPlayer1;
        public System.Windows.Forms.TextBox txtPlayer2;
    }
}