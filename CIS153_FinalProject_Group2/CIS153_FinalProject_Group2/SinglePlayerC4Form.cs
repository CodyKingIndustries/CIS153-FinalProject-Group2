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

        private void btn_Row1Slot_Click(object sender, EventArgs e)
        {
            if (btn_Row1Space1.BackColor == Color.White)
            {
                btn_Row1Space1.BackColor = Color.Green;
            }
            else if (btn_Row1Space2.BackColor == Color.White && btn_Row1Space1.BackColor != Color.White)
            {
                btn_Row1Space2.BackColor = Color.Green;
            }
            else if (btn_Row1Space3.BackColor == Color.White && btn_Row1Space2.BackColor != Color.White)
            {
                btn_Row1Space3.BackColor = Color.Green;
            }
            else if (btn_Row1Space3.BackColor == Color.White && btn_Row1Space2.BackColor != Color.White)
            {
                btn_Row1Space3.BackColor = Color.Green;
            }
            else if (btn_Row1Space4.BackColor == Color.White && btn_Row1Space3.BackColor != Color.White)
            {
                btn_Row1Space4.BackColor = Color.Green;
            }
            else if (btn_Row1Space5.BackColor == Color.White && btn_Row1Space4.BackColor != Color.White)
            {
                btn_Row1Space5.BackColor = Color.Green;
            }
            else if (btn_Row1Space6.BackColor == Color.White && btn_Row1Space5.BackColor != Color.White)
            {
                btn_Row1Space6.BackColor = Color.Green;
            }
        }

        private void btn_Row2Slot_Click(object sender, EventArgs e)
        {
            if (btn_Row2Space1.BackColor == Color.White)
            {
                btn_Row2Space1.BackColor = Color.Green;
            }
            else if (btn_Row2Space2.BackColor == Color.White && btn_Row2Space1.BackColor != Color.White)
            {
                btn_Row2Space2.BackColor = Color.Green;
            }
            else if (btn_Row2Space3.BackColor == Color.White && btn_Row2Space2.BackColor != Color.White)
            {
                btn_Row2Space3.BackColor = Color.Green;
            }
            else if (btn_Row2Space3.BackColor == Color.White && btn_Row2Space2.BackColor != Color.White)
            {
                btn_Row2Space3.BackColor = Color.Green;
            }
            else if (btn_Row2Space4.BackColor == Color.White && btn_Row2Space3.BackColor != Color.White)
            {
                btn_Row2Space4.BackColor = Color.Green;
            }
            else if (btn_Row2Space5.BackColor == Color.White && btn_Row2Space4.BackColor != Color.White)
            {
                btn_Row2Space5.BackColor = Color.Green;
            }
            else if (btn_Row2Space6.BackColor == Color.White && btn_Row2Space5.BackColor != Color.White)
            {
                btn_Row2Space6.BackColor = Color.Green;
            }
        }

        private void btn_Row3Slot_Click(object sender, EventArgs e)
        {
            if (btn_Row3Space1.BackColor == Color.White)
            {
                btn_Row3Space1.BackColor = Color.Green;
            }
            else if (btn_Row3Space2.BackColor == Color.White && btn_Row3Space1.BackColor != Color.White)
            {
                btn_Row3Space2.BackColor = Color.Green;
            }
            else if (btn_Row3Space3.BackColor == Color.White && btn_Row3Space2.BackColor != Color.White)
            {
                btn_Row3Space3.BackColor = Color.Green;
            }
            else if (btn_Row3Space3.BackColor == Color.White && btn_Row3Space2.BackColor != Color.White)
            {
                btn_Row3Space3.BackColor = Color.Green;
            }
            else if (btn_Row3Space4.BackColor == Color.White && btn_Row3Space3.BackColor != Color.White)
            {
                btn_Row3Space4.BackColor = Color.Green;
            }
            else if (btn_Row3Space5.BackColor == Color.White && btn_Row3Space4.BackColor != Color.White)
            {
                btn_Row3Space5.BackColor = Color.Green;
            }
            else if (btn_Row3Space6.BackColor == Color.White && btn_Row3Space5.BackColor != Color.White)
            {
                btn_Row3Space6.BackColor = Color.Green;
            }
        }

        private void btn_Row4Slot_Click(object sender, EventArgs e)
        {
            if (btn_Row4Space1.BackColor == Color.White)
            {
                btn_Row4Space1.BackColor = Color.Green;
            }
            else if (btn_Row4Space2.BackColor == Color.White && btn_Row4Space1.BackColor != Color.White)
            {
                btn_Row4Space2.BackColor = Color.Green;
            }
            else if (btn_Row4Space3.BackColor == Color.White && btn_Row4Space2.BackColor != Color.White)
            {
                btn_Row4Space3.BackColor = Color.Green;
            }
            else if (btn_Row4Space3.BackColor == Color.White && btn_Row4Space2.BackColor != Color.White)
            {
                btn_Row4Space3.BackColor = Color.Green;
            }
            else if (btn_Row4Space4.BackColor == Color.White && btn_Row4Space3.BackColor != Color.White)
            {
                btn_Row4Space4.BackColor = Color.Green;
            }
            else if (btn_Row4Space5.BackColor == Color.White && btn_Row4Space4.BackColor != Color.White)
            {
                btn_Row4Space5.BackColor = Color.Green;
            }
            else if (btn_Row4Space6.BackColor == Color.White && btn_Row4Space5.BackColor != Color.White)
            {
                btn_Row4Space6.BackColor = Color.Green;
            }
        }

        private void btn_Row5Slot_Click(object sender, EventArgs e)
        {
            if (btn_Row5Space1.BackColor == Color.White)
            {
                btn_Row5Space1.BackColor = Color.Green;
            }
            else if (btn_Row5Space2.BackColor == Color.White && btn_Row5Space1.BackColor != Color.White)
            {
                btn_Row5Space2.BackColor = Color.Green;
            }
            else if (btn_Row5Space3.BackColor == Color.White && btn_Row5Space2.BackColor != Color.White)
            {
                btn_Row5Space3.BackColor = Color.Green;
            }
            else if (btn_Row5Space3.BackColor == Color.White && btn_Row5Space2.BackColor != Color.White)
            {
                btn_Row5Space3.BackColor = Color.Green;
            }
            else if (btn_Row5Space4.BackColor == Color.White && btn_Row5Space3.BackColor != Color.White)
            {
                btn_Row5Space4.BackColor = Color.Green;
            }
            else if (btn_Row5Space5.BackColor == Color.White && btn_Row5Space4.BackColor != Color.White)
            {
                btn_Row5Space5.BackColor = Color.Green;
            }
            else if (btn_Row5Space6.BackColor == Color.White && btn_Row5Space5.BackColor != Color.White)
            {
                btn_Row5Space6.BackColor = Color.Green;
            }
        }

        private void btn_Row6Slot_Click(object sender, EventArgs e)
        {
            if (btn_Row6Space1.BackColor == Color.White)
            {
                btn_Row6Space1.BackColor = Color.Green;
            }
            else if (btn_Row6Space2.BackColor == Color.White && btn_Row6Space1.BackColor != Color.White)
            {
                btn_Row6Space2.BackColor = Color.Green;
            }
            else if (btn_Row6Space3.BackColor == Color.White && btn_Row6Space2.BackColor != Color.White)
            {
                btn_Row6Space3.BackColor = Color.Green;
            }
            else if (btn_Row6Space3.BackColor == Color.White && btn_Row6Space2.BackColor != Color.White)
            {
                btn_Row6Space3.BackColor = Color.Green;
            }
            else if (btn_Row6Space4.BackColor == Color.White && btn_Row6Space3.BackColor != Color.White)
            {
                btn_Row6Space4.BackColor = Color.Green;
            }
            else if (btn_Row6Space5.BackColor == Color.White && btn_Row6Space4.BackColor != Color.White)
            {
                btn_Row6Space5.BackColor = Color.Green;
            }
            else if (btn_Row6Space6.BackColor == Color.White && btn_Row6Space5.BackColor != Color.White)
            {
                btn_Row6Space6.BackColor = Color.Green;
            }
        }

        private void btn_Row7Slot_Click(object sender, EventArgs e)
        {
            if (btn_Row7Space1.BackColor == Color.White)
            {
                btn_Row7Space1.BackColor = Color.Green;
            }
            else if (btn_Row7Space2.BackColor == Color.White && btn_Row7Space1.BackColor != Color.White)
            {
                btn_Row7Space2.BackColor = Color.Green;
            }
            else if (btn_Row7Space3.BackColor == Color.White && btn_Row7Space2.BackColor != Color.White)
            {
                btn_Row7Space3.BackColor = Color.Green;
            }
            else if (btn_Row7Space3.BackColor == Color.White && btn_Row7Space2.BackColor != Color.White)
            {
                btn_Row7Space3.BackColor = Color.Green;
            }
            else if (btn_Row7Space4.BackColor == Color.White && btn_Row7Space3.BackColor != Color.White)
            {
                btn_Row7Space4.BackColor = Color.Green;
            }
            else if (btn_Row7Space5.BackColor == Color.White && btn_Row7Space4.BackColor != Color.White)
            {
                btn_Row7Space5.BackColor = Color.Green;
            }
            else if (btn_Row7Space6.BackColor == Color.White && btn_Row7Space5.BackColor != Color.White)
            {
                btn_Row7Space6.BackColor = Color.Green;
            }
        }
    }
}
