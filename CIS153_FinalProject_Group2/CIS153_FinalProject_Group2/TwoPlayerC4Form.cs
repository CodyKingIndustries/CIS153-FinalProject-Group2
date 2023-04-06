﻿using System;
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
        private MainMenuForm MainScreenForm;
        public TwoPlayerC4Form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
        }

        public TwoPlayerC4Form(MainMenuForm m)
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
