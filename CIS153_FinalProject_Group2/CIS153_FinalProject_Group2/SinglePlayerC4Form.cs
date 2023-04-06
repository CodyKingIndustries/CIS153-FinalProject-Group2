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
    public partial class SinglePlayerC4Form : Form
    {
        //  this is a global reference to the Home Screen of Connect 4
        private MainMenuForm MainScreenForm;

        public SinglePlayerC4Form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
        }

        //  Initialize This Form
        public SinglePlayerC4Form(MainMenuForm m)
        {
            InitializeComponent();
            //  this will allow us to return to the main screen form if we need to
            MainScreenForm = m;
        }


        private void SinglePlayerC4Form_Load(object sender, EventArgs e)
        {

        }

        //  Return to Main Screen
        private void btn_SPC4_tempLoadForm_Click(object sender, EventArgs e)
        {
            MainScreenForm.Show();
            //  in order for this to close -> either the game needs to end / or the user must exit
            //  this is just temporary framework
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
