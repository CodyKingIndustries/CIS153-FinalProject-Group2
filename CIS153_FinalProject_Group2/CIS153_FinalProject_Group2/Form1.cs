//Gabriel Ball
//Evan Harbaugh
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}

//  Quick temporary game plan:  [just my initial thoughts, thus oviously will change once we start communicating]
//  -Classes and the forms seem pretty interchange-able for any of us to work on due to their relative simplicity
//  -however the cpu ai would make the most sence to dedicate a single member to exclusively work on it, due to the complexity
//   and odds that the others misinterpret/mess up the design accidentaly.
//  -In terms of visuals I am stating now that I am awful at it, and as such, would be nice if another member who is good
//   would vaugly take charge of that aspect [In the past I litterly just made a massive button and changed its color for the background]
//  -Anything I said that is either completer garbage/lacking/other just say it/add/remove it because this is a group effort, and thus
//   I am only making this temporary game plan to establish a base to go off of.

//  Final personal note: I Evan Harbaugh, for "puch out coding" reference:
//  I am most and frequently available to spend time coding thursday-sunday in general times between[11am-9pm]
//  But am still available, just less so mon-wed.  ok im done text dumping you all