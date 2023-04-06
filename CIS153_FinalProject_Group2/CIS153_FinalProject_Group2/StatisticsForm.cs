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
    }
}
