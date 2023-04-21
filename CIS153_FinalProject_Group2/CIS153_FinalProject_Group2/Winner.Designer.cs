namespace CIS153_FinalProject_Group2
{
    partial class Winner
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
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.btn_playAgain = new System.Windows.Forms.Button();
            this.btn_loadStatistics = new System.Windows.Forms.Button();
            this.txt_Winner = new System.Windows.Forms.TextBox();
            this.btn_reviewBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(140, 329);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(135, 37);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_mainMenu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainMenu.Location = new System.Drawing.Point(126, 274);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(162, 37);
            this.btn_mainMenu.TabIndex = 7;
            this.btn_mainMenu.Text = "Return To Main Menu";
            this.btn_mainMenu.UseVisualStyleBackColor = false;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // btn_playAgain
            // 
            this.btn_playAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_playAgain.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playAgain.Location = new System.Drawing.Point(126, 217);
            this.btn_playAgain.Name = "btn_playAgain";
            this.btn_playAgain.Size = new System.Drawing.Size(162, 37);
            this.btn_playAgain.TabIndex = 6;
            this.btn_playAgain.Text = "Play Again";
            this.btn_playAgain.UseVisualStyleBackColor = false;
            this.btn_playAgain.Click += new System.EventHandler(this.btn_playAgain_Click);
            // 
            // btn_loadStatistics
            // 
            this.btn_loadStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_loadStatistics.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadStatistics.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_loadStatistics.Location = new System.Drawing.Point(126, 157);
            this.btn_loadStatistics.Name = "btn_loadStatistics";
            this.btn_loadStatistics.Size = new System.Drawing.Size(162, 37);
            this.btn_loadStatistics.TabIndex = 5;
            this.btn_loadStatistics.Text = "Single Player Statistics";
            this.btn_loadStatistics.UseVisualStyleBackColor = false;
            this.btn_loadStatistics.Click += new System.EventHandler(this.btn_loadStatistics_Click);
            // 
            // txt_Winner
            // 
            this.txt_Winner.BackColor = System.Drawing.Color.Blue;
            this.txt_Winner.Font = new System.Drawing.Font("Arial Narrow", 28F, System.Drawing.FontStyle.Bold);
            this.txt_Winner.ForeColor = System.Drawing.Color.White;
            this.txt_Winner.Location = new System.Drawing.Point(85, 26);
            this.txt_Winner.Name = "txt_Winner";
            this.txt_Winner.Size = new System.Drawing.Size(245, 50);
            this.txt_Winner.TabIndex = 11;
            this.txt_Winner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_reviewBoard
            // 
            this.btn_reviewBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_reviewBoard.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reviewBoard.Location = new System.Drawing.Point(126, 97);
            this.btn_reviewBoard.Name = "btn_reviewBoard";
            this.btn_reviewBoard.Size = new System.Drawing.Size(162, 37);
            this.btn_reviewBoard.TabIndex = 14;
            this.btn_reviewBoard.Text = "Review Board";
            this.btn_reviewBoard.UseVisualStyleBackColor = false;
            this.btn_reviewBoard.Click += new System.EventHandler(this.btn_reviewBoard_Click);
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(428, 389);
            this.Controls.Add(this.btn_reviewBoard);
            this.Controls.Add(this.txt_Winner);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_mainMenu);
            this.Controls.Add(this.btn_playAgain);
            this.Controls.Add(this.btn_loadStatistics);
            this.Name = "Winner";
            this.Text = "Winner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Button btn_playAgain;
        private System.Windows.Forms.Button btn_loadStatistics;
        private System.Windows.Forms.TextBox txt_Winner;
        private System.Windows.Forms.Button btn_reviewBoard;
    }
}