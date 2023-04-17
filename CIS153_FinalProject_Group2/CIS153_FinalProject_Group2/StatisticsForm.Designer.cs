namespace CIS153_FinalProject_Group2
{
    partial class StatisticsForm
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_loadMenu = new System.Windows.Forms.Button();
            this.lbl_playerWinstxt = new System.Windows.Forms.Label();
            this.lbl_playerWins = new System.Windows.Forms.Label();
            this.lbl_aiWinsTxt = new System.Windows.Forms.Label();
            this.lbl_aiWins = new System.Windows.Forms.Label();
            this.lbl_tiesTxt = new System.Windows.Forms.Label();
            this.lbl_ties = new System.Windows.Forms.Label();
            this.lbl_playerWinPercentTxt = new System.Windows.Forms.Label();
            this.lbl_playerWinPercent = new System.Windows.Forms.Label();
            this.lbl_aiWinPercentTxt = new System.Windows.Forms.Label();
            this.lbl_aiWinPercentage = new System.Windows.Forms.Label();
            this.lbl_gamesPlayedTxt = new System.Windows.Forms.Label();
            this.lbl_gamesPlayed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(205, 408);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(134, 36);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_loadMenu
            // 
            this.btn_loadMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_loadMenu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadMenu.ForeColor = System.Drawing.Color.Black;
            this.btn_loadMenu.Location = new System.Drawing.Point(12, 408);
            this.btn_loadMenu.Name = "btn_loadMenu";
            this.btn_loadMenu.Size = new System.Drawing.Size(141, 36);
            this.btn_loadMenu.TabIndex = 1;
            this.btn_loadMenu.Text = "Load Menu";
            this.btn_loadMenu.UseVisualStyleBackColor = false;
            this.btn_loadMenu.Click += new System.EventHandler(this.btn_loadMenu_Click);
            // 
            // lbl_playerWinstxt
            // 
            this.lbl_playerWinstxt.AutoSize = true;
            this.lbl_playerWinstxt.BackColor = System.Drawing.Color.Red;
            this.lbl_playerWinstxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerWinstxt.ForeColor = System.Drawing.Color.Black;
            this.lbl_playerWinstxt.Location = new System.Drawing.Point(15, 9);
            this.lbl_playerWinstxt.Name = "lbl_playerWinstxt";
            this.lbl_playerWinstxt.Size = new System.Drawing.Size(86, 20);
            this.lbl_playerWinstxt.TabIndex = 2;
            this.lbl_playerWinstxt.Text = "Player Wins:";
            this.lbl_playerWinstxt.Click += new System.EventHandler(this.lbl_playerWinstxt_Click);
            // 
            // lbl_playerWins
            // 
            this.lbl_playerWins.AutoSize = true;
            this.lbl_playerWins.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerWins.ForeColor = System.Drawing.Color.White;
            this.lbl_playerWins.Location = new System.Drawing.Point(33, 35);
            this.lbl_playerWins.Name = "lbl_playerWins";
            this.lbl_playerWins.Size = new System.Drawing.Size(0, 20);
            this.lbl_playerWins.TabIndex = 3;
            // 
            // lbl_aiWinsTxt
            // 
            this.lbl_aiWinsTxt.AutoSize = true;
            this.lbl_aiWinsTxt.BackColor = System.Drawing.Color.Yellow;
            this.lbl_aiWinsTxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aiWinsTxt.Location = new System.Drawing.Point(15, 70);
            this.lbl_aiWinsTxt.Name = "lbl_aiWinsTxt";
            this.lbl_aiWinsTxt.Size = new System.Drawing.Size(60, 20);
            this.lbl_aiWinsTxt.TabIndex = 4;
            this.lbl_aiWinsTxt.Text = "AI Wins:";
            // 
            // lbl_aiWins
            // 
            this.lbl_aiWins.AutoSize = true;
            this.lbl_aiWins.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aiWins.ForeColor = System.Drawing.Color.White;
            this.lbl_aiWins.Location = new System.Drawing.Point(33, 104);
            this.lbl_aiWins.Name = "lbl_aiWins";
            this.lbl_aiWins.Size = new System.Drawing.Size(0, 20);
            this.lbl_aiWins.TabIndex = 5;
            // 
            // lbl_tiesTxt
            // 
            this.lbl_tiesTxt.AutoSize = true;
            this.lbl_tiesTxt.BackColor = System.Drawing.Color.Orange;
            this.lbl_tiesTxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiesTxt.Location = new System.Drawing.Point(15, 129);
            this.lbl_tiesTxt.Name = "lbl_tiesTxt";
            this.lbl_tiesTxt.Size = new System.Drawing.Size(39, 20);
            this.lbl_tiesTxt.TabIndex = 6;
            this.lbl_tiesTxt.Text = "Ties:";
            // 
            // lbl_ties
            // 
            this.lbl_ties.AutoSize = true;
            this.lbl_ties.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ties.ForeColor = System.Drawing.Color.White;
            this.lbl_ties.Location = new System.Drawing.Point(33, 164);
            this.lbl_ties.Name = "lbl_ties";
            this.lbl_ties.Size = new System.Drawing.Size(0, 20);
            this.lbl_ties.TabIndex = 7;
            // 
            // lbl_playerWinPercentTxt
            // 
            this.lbl_playerWinPercentTxt.AutoSize = true;
            this.lbl_playerWinPercentTxt.BackColor = System.Drawing.Color.Red;
            this.lbl_playerWinPercentTxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerWinPercentTxt.Location = new System.Drawing.Point(9, 196);
            this.lbl_playerWinPercentTxt.Name = "lbl_playerWinPercentTxt";
            this.lbl_playerWinPercentTxt.Size = new System.Drawing.Size(152, 20);
            this.lbl_playerWinPercentTxt.TabIndex = 8;
            this.lbl_playerWinPercentTxt.Text = "Player Win Percentage:";
            // 
            // lbl_playerWinPercent
            // 
            this.lbl_playerWinPercent.AutoSize = true;
            this.lbl_playerWinPercent.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerWinPercent.ForeColor = System.Drawing.Color.White;
            this.lbl_playerWinPercent.Location = new System.Drawing.Point(34, 236);
            this.lbl_playerWinPercent.Name = "lbl_playerWinPercent";
            this.lbl_playerWinPercent.Size = new System.Drawing.Size(0, 20);
            this.lbl_playerWinPercent.TabIndex = 9;
            // 
            // lbl_aiWinPercentTxt
            // 
            this.lbl_aiWinPercentTxt.AutoSize = true;
            this.lbl_aiWinPercentTxt.BackColor = System.Drawing.Color.Yellow;
            this.lbl_aiWinPercentTxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aiWinPercentTxt.Location = new System.Drawing.Point(9, 269);
            this.lbl_aiWinPercentTxt.Name = "lbl_aiWinPercentTxt";
            this.lbl_aiWinPercentTxt.Size = new System.Drawing.Size(126, 20);
            this.lbl_aiWinPercentTxt.TabIndex = 10;
            this.lbl_aiWinPercentTxt.Text = "AI Win Percentage:";
            // 
            // lbl_aiWinPercentage
            // 
            this.lbl_aiWinPercentage.AutoSize = true;
            this.lbl_aiWinPercentage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aiWinPercentage.ForeColor = System.Drawing.Color.White;
            this.lbl_aiWinPercentage.Location = new System.Drawing.Point(33, 304);
            this.lbl_aiWinPercentage.Name = "lbl_aiWinPercentage";
            this.lbl_aiWinPercentage.Size = new System.Drawing.Size(0, 20);
            this.lbl_aiWinPercentage.TabIndex = 11;
            // 
            // lbl_gamesPlayedTxt
            // 
            this.lbl_gamesPlayedTxt.AutoSize = true;
            this.lbl_gamesPlayedTxt.BackColor = System.Drawing.Color.Orange;
            this.lbl_gamesPlayedTxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamesPlayedTxt.Location = new System.Drawing.Point(9, 342);
            this.lbl_gamesPlayedTxt.Name = "lbl_gamesPlayedTxt";
            this.lbl_gamesPlayedTxt.Size = new System.Drawing.Size(102, 20);
            this.lbl_gamesPlayedTxt.TabIndex = 12;
            this.lbl_gamesPlayedTxt.Text = "Games Played:";
            // 
            // lbl_gamesPlayed
            // 
            this.lbl_gamesPlayed.AutoSize = true;
            this.lbl_gamesPlayed.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamesPlayed.ForeColor = System.Drawing.Color.White;
            this.lbl_gamesPlayed.Location = new System.Drawing.Point(33, 376);
            this.lbl_gamesPlayed.Name = "lbl_gamesPlayed";
            this.lbl_gamesPlayed.Size = new System.Drawing.Size(0, 20);
            this.lbl_gamesPlayed.TabIndex = 13;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(351, 456);
            this.Controls.Add(this.lbl_gamesPlayed);
            this.Controls.Add(this.lbl_gamesPlayedTxt);
            this.Controls.Add(this.lbl_aiWinPercentage);
            this.Controls.Add(this.lbl_aiWinPercentTxt);
            this.Controls.Add(this.lbl_playerWinPercent);
            this.Controls.Add(this.lbl_playerWinPercentTxt);
            this.Controls.Add(this.lbl_ties);
            this.Controls.Add(this.lbl_tiesTxt);
            this.Controls.Add(this.lbl_aiWins);
            this.Controls.Add(this.lbl_aiWinsTxt);
            this.Controls.Add(this.lbl_playerWins);
            this.Controls.Add(this.lbl_playerWinstxt);
            this.Controls.Add(this.btn_loadMenu);
            this.Controls.Add(this.btn_Exit);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_loadMenu;
        private System.Windows.Forms.Label lbl_playerWinstxt;
        private System.Windows.Forms.Label lbl_playerWins;
        private System.Windows.Forms.Label lbl_aiWinsTxt;
        private System.Windows.Forms.Label lbl_aiWins;
        private System.Windows.Forms.Label lbl_tiesTxt;
        private System.Windows.Forms.Label lbl_ties;
        private System.Windows.Forms.Label lbl_playerWinPercentTxt;
        private System.Windows.Forms.Label lbl_playerWinPercent;
        private System.Windows.Forms.Label lbl_aiWinPercentTxt;
        private System.Windows.Forms.Label lbl_aiWinPercentage;
        private System.Windows.Forms.Label lbl_gamesPlayedTxt;
        private System.Windows.Forms.Label lbl_gamesPlayed;
    }
}