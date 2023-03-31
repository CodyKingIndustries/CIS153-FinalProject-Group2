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
    public partial class TwoPlayerC4Form : Form
    {
        private Form1 MainScreenForm;
        public TwoPlayerC4Form()
        {
            InitializeComponent();
        }

        public TwoPlayerC4Form(Form1 m)
        {
            InitializeComponent();
            MainScreenForm = m;
        }

        private void TwoPlayerC4Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_TPC4F_tempLoadForm_Click(object sender, EventArgs e)
        {
            MainScreenForm.Show();
            //  in order for this to close -> either the game needs to end / or the user must exit
            //  this is just temporary framework
            this.Close();
        }
    }
}
