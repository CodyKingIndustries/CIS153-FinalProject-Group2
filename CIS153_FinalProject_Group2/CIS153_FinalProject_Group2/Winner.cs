using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject_Group2
{
    public partial class Winner : Form
    {
        private MainMenuForm MainScreenForm;
        private SinglePlayerC4Form SPForm;
        private TwoPlayerC4Form TPForm;
        private int winner;
        private string cameFrom;

        public Winner()
        {
            InitializeComponent();
        }

        //Coming from SinglePlayer Game
        public Winner(SinglePlayerC4Form s, MainMenuForm m, int i)
        {
            InitializeComponent();
            SPForm = s;
            MainScreenForm = m;
            winner = i;
            cameFrom = "Single";

            if (winner == 0)
            {
                txt_Winner.Text = "Player 1 Wins!";
            }
            else if (winner == 1)
            {
                txt_Winner.Text = "AI Wins!";
            }
            else
            {
                //Tie
                txt_Winner.Text = "Tie Game!";
            }
        }

        //Coming from TwoPlayer Game
        public Winner(TwoPlayerC4Form t, MainMenuForm m, int i)
        {
            InitializeComponent();
            TPForm = t;
            MainScreenForm = m;
            winner = i;
            cameFrom = "Two";

            if (winner == 0)
            {
                txt_Winner.Text = "Player 1 Wins!";
            }
            else if (winner == 1)
            {
                txt_Winner.Text = "Player 2 Wins!";
            }
            else
            {
                //Tie
                txt_Winner.Text = "Tie Game!";
            }
        }

        private void btn_reviewBoard_Click(object sender, EventArgs e)
        {
            //Review board isn't completely done since there are more things to do as
            //layed out in rubric but here is a start:

            if (cameFrom == "Two")
            {
                TPForm.Show();
                this.Close();
                //Can't decide if I should hide or close for reviewing board
                //this.Hide();
            }
            else if (cameFrom == "Single")
            {
                SPForm.Show();
                this.Close();
                //Can't decide if I should hide or close for reviewing board
                //this.Hide();
            }
        }

        private void btn_loadStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm statsForm = new StatisticsForm(MainScreenForm);
            statsForm.Show();
            this.Close();
            //Again, can't yet decide whether or not to hide or close
            //this.Hide();
        }

        private void btn_playAgain_Click(object sender, EventArgs e)
        {
            if (cameFrom == "Two")
            {
                TwoPlayerC4Form TPForm = new TwoPlayerC4Form(MainScreenForm);
                TPForm.Show();
                this.Close();
            }
            else if (cameFrom == "Single")
            {
                SinglePlayerC4Form TPForm = new SinglePlayerC4Form(MainScreenForm);
                SPForm.Show();
                this.Close();
            }
        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm MainScreenForm = new MainMenuForm();
            MainScreenForm.Show();
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
