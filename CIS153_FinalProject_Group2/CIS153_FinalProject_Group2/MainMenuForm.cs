//Gabriel Ball
//Evan Harbaugh
//Cody King
//Will Bushroe
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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //  Load Single Player
        private void btn_TempLoadForm_Click(object sender, EventArgs e)
        {
            //  clicking this button will load a new "SinglePlayerC4Form" form
            //                                       [Single Player Connect 4 Form]
            SinglePlayerC4Form SinglePForm = new SinglePlayerC4Form(this);
            //  this will transition to display the new single player form
            this.Hide();
            SinglePForm.Show();
        }

        //  Load Two Player
        private void btn_tempLoadTPC4F_Click(object sender, EventArgs e)
        {
            //  clicking this button will load a new "TwoPlayerC4Form" form
            //                                       [Two Player Connect 4 Form]
            TwoPlayerC4Form TwoPForm = new TwoPlayerC4Form(this);
            //  this will transition to display the new Two player form
            this.Hide();
            TwoPForm.Show();
        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            //clicking this loads a statistics board
            StatisticsForm Statform = new StatisticsForm(this);
            //transition
            this.Hide();
            Statform.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

