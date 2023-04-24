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

namespace CIS153_FinalProject_Group2
{
    public partial class StatisticsForm : Form
    {
        private MainMenuForm MainScreenForm;


        public StatisticsForm()
        {
            InitializeComponent();

        }

        public StatisticsForm(MainMenuForm m)
        {
            InitializeComponent();
            MainScreenForm = m;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("stats.txt"))
            {
                // Open the text file containing the statistics
                StreamReader reader = new StreamReader("stats.txt");

                // Read the statistics from the text file and replace null values with 0
                int playerWins = 0;
                string playerWinsStr = reader.ReadLine();
                if (playerWinsStr != null)
                {
                    playerWins = int.Parse(playerWinsStr);
                }

                int computerWins = 0;
                string computerWinsStr = reader.ReadLine();
                if (computerWinsStr != null)
                {
                    computerWins = int.Parse(computerWinsStr);
                }

                int ties = 0;
                string tiesStr = reader.ReadLine();
                if (tiesStr != null)
                {
                    ties = int.Parse(tiesStr);
                }

                int totalGames = 0;
                string totalGamesStr = reader.ReadLine();
                if (totalGamesStr != null)
                {
                    totalGames = int.Parse(totalGamesStr);
                }

                // Close the reader
                reader.Close();
                UpdateStatisticsLabels(playerWins, computerWins, ties, totalGames);
            }
            else
            {
                MessageBox.Show("The file stats.txt does not exist.");
            }


        }

        private void UpdateStatisticsLabels(int playerWins, int aiWins, int ties, int totalGames)
        {
            lbl_playerWins.Text = playerWins.ToString();
            lbl_aiWins.Text = aiWins.ToString();
            lbl_ties.Text = ties.ToString();
            lbl_gamesPlayed.Text = totalGames.ToString();

            // Calculate win percentages
            double playerWinPercentage = (double)playerWins / totalGames * 100;
            double aiWinPercentage = (double)aiWins / totalGames * 100;

            // Update the win percentage labels
            lbl_playerWinPercent.Text = string.Format("{0:0.00}%", playerWinPercentage);
            lbl_aiWinPercentage.Text = string.Format("{0:0.00}%", aiWinPercentage);
        }

        private void btn_loadMenu_Click(object sender, EventArgs e)
        {
            MainScreenForm.Show();
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lbl_playerWinstxt_Click (object sender, EventArgs e)
        {

        }
    }
}
