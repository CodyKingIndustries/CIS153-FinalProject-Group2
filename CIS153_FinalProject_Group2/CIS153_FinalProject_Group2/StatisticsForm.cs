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
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
        }
        public StatisticsForm(MainMenuForm m)
        {
            InitializeComponent();
            MainScreenForm = m;
        }
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            // Open the text file containing the statistics
            StreamReader reader = new StreamReader("stats.txt");


            //saving this for when it is needed

            // Read the statistics from the text file
            //int playerWins = int.Parse(reader.ReadLine());
            //int computerWins = int.Parse(reader.ReadLine());
            //int ties = int.Parse(reader.ReadLine());
            //int totalGames = int.Parse(reader.ReadLine());

            // Close the reader
            reader.Close();

            //Notes:
            //We need to add win counters for ai and player,
            //tie counters, and games played counters to 
            //single player, and I can finish the statistics page
            //with everyone

            //Also, I named the labels with and without "Txt"
            //Since I have labels instead of text boxes you wont see anything
            //in the design form, I just think it looks better that way

            //Testing how a label looks when the value is added from this code
            //So everyone can mess around with looks easier
            lbl_playerWins.Text = "1";
            lbl_aiWins.Text ="1";
            lbl_ties.Text ="1";
            lbl_playerWinPercent.Text = "1";
            lbl_aiWinPercentage.Text = "1";
            lbl_gamesPlayed.Text = "1";
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

        private void lbl_playerWinstxt_Click(object sender, EventArgs e)
        {

        }
    }
}
