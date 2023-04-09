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
        //  This is to keep track if the purple button was clicked for the hover requirement
        private int RowOneClick = 0;
        private int RowTwoClick = 0;
        private int RowThreeClick = 0;
        private int RowFourClick = 0;
        private int RowFiveClick = 0;
        private int RowSixClick = 0;
        private int RowSevenClick = 0;

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
            if (RowOneClick < 1)
            {
                btn_Row1Space1.BackColor = Color.Green;
                RowOneClick = 1;
            }
            else if (RowOneClick < 2)
            {
                btn_Row1Space2.BackColor = Color.Green;
                RowOneClick = 2;
            }
            else if (RowOneClick < 3)
            {
                btn_Row1Space3.BackColor = Color.Green;
                RowOneClick = 3;
            }
            else if (RowOneClick < 4)
            {
                btn_Row1Space4.BackColor = Color.Green;
                RowOneClick = 4;
            }
            else if (RowOneClick < 5)
            {
                btn_Row1Space5.BackColor = Color.Green;
                RowOneClick = 5;
            }
            else if (RowOneClick < 6)
            {
                btn_Row1Space6.BackColor = Color.Green;
                RowOneClick = 6;
            }
        }

        private void btn_Row2Slot_Click(object sender, EventArgs e)
        {
            if (RowTwoClick < 1)
            {
                btn_Row2Space1.BackColor = Color.Green;
                RowTwoClick = 1;
            }
            else if (RowTwoClick < 2)
            {
                btn_Row2Space2.BackColor = Color.Green;
                RowTwoClick = 2;
            }
            else if (RowTwoClick < 3)
            {
                btn_Row2Space3.BackColor = Color.Green;
                RowTwoClick = 3;
            }
            else if (RowTwoClick < 4)
            {
                btn_Row2Space4.BackColor = Color.Green;
                RowTwoClick = 4;
            }
            else if (RowTwoClick < 5)
            {
                btn_Row2Space5.BackColor = Color.Green;
                RowTwoClick = 5;
            }
            else if (RowTwoClick < 6)
            {
                btn_Row2Space6.BackColor = Color.Green;
                RowTwoClick = 6;
            }
        }

        private void btn_Row3Slot_Click(object sender, EventArgs e)
        {
            if (RowThreeClick < 1)
            {
                btn_Row3Space1.BackColor = Color.Green;
                RowThreeClick = 1;
            }
            else if (RowThreeClick < 2)
            {
                btn_Row3Space2.BackColor = Color.Green;
                RowThreeClick = 2;
            }
            else if (RowThreeClick < 3)
            {
                btn_Row3Space3.BackColor = Color.Green;
                RowThreeClick = 3;
            }
            else if (RowThreeClick < 4)
            {
                btn_Row3Space4.BackColor = Color.Green;
                RowThreeClick = 4;
            }
            else if (RowThreeClick < 5)
            {
                btn_Row3Space5.BackColor = Color.Green;
                RowThreeClick = 5;
            }
            else if (RowThreeClick < 6)
            {
                btn_Row3Space6.BackColor = Color.Green;
                RowThreeClick = 6;
            }
        }

        private void btn_Row4Slot_Click(object sender, EventArgs e)
        {
            if (RowFourClick < 1)
            {
                btn_Row4Space1.BackColor = Color.Green;
                RowFourClick = 1;
            }
            else if (RowFourClick < 2)
            {
                btn_Row4Space2.BackColor = Color.Green;
                RowFourClick = 2;
            }
            else if (RowFourClick < 3)
            {
                btn_Row4Space3.BackColor = Color.Green;
                RowFourClick = 3;
            }
            else if (RowFourClick < 4)
            {
                btn_Row4Space4.BackColor = Color.Green;
                RowFourClick = 4;
            }
            else if (RowFourClick < 5)
            {
                btn_Row4Space5.BackColor = Color.Green;
                RowFourClick = 5;
            }
            else if (RowFourClick < 6)
            {
                btn_Row4Space6.BackColor = Color.Green;
                RowFourClick = 6;
            }
        }

        private void btn_Row5Slot_Click(object sender, EventArgs e)
        {
            if (RowFiveClick < 1)
            {
                btn_Row5Space1.BackColor = Color.Green;
                RowFiveClick = 1;
            }
            else if (RowFiveClick < 2)
            {
                btn_Row5Space2.BackColor = Color.Green;
                RowFiveClick = 2;
            }
            else if (RowFiveClick < 3)
            {
                btn_Row5Space3.BackColor = Color.Green;
                RowFiveClick = 3;
            }
            else if (RowFiveClick < 4)
            {
                btn_Row5Space4.BackColor = Color.Green;
                RowFiveClick = 4;
            }
            else if (RowFiveClick < 5)
            {
                btn_Row5Space5.BackColor = Color.Green;
                RowFiveClick = 5;
            }
            else if (RowFiveClick < 6)
            {
                btn_Row5Space6.BackColor = Color.Green;
                RowFiveClick = 6;
            }
        }

        private void btn_Row6Slot_Click(object sender, EventArgs e)
        {
            if (RowSixClick < 1)
            {
                btn_Row6Space1.BackColor = Color.Green;
                RowSixClick = 1;
            }
            else if (RowSixClick < 2)
            {
                btn_Row6Space2.BackColor = Color.Green;
                RowSixClick = 2;
            }
            else if (RowSixClick < 3)
            {
                btn_Row6Space3.BackColor = Color.Green;
                RowSixClick = 3;
            }
            else if (RowSixClick < 4)
            {
                btn_Row6Space4.BackColor = Color.Green;
                RowSixClick = 4;
            }
            else if (RowSixClick < 5)
            {
                btn_Row6Space5.BackColor = Color.Green;
                RowSixClick = 5;
            }
            else if (RowSixClick < 6)
            {
                btn_Row6Space6.BackColor = Color.Green;
                RowSixClick = 6;
            }
        }

        private void btn_Row7Slot_Click(object sender, EventArgs e)
        {
            if (RowSevenClick < 1)
            {
                btn_Row7Space1.BackColor = Color.Green;
                RowSevenClick = 1;
            }
            else if (RowSevenClick < 2)
            {
                btn_Row7Space2.BackColor = Color.Green;
                RowSevenClick = 2;
            }
            else if (RowSevenClick < 3)
            {
                btn_Row7Space3.BackColor = Color.Green;
                RowSevenClick = 3;
            }
            else if (RowSevenClick < 4)
            {
                btn_Row7Space4.BackColor = Color.Green;
                RowSevenClick = 4;
            }
            else if (RowSevenClick < 5)
            {
                btn_Row7Space5.BackColor = Color.Green;
                RowSevenClick = 5;
            }
            else if (RowSevenClick < 6)
            {
                btn_Row7Space6.BackColor = Color.Green;
                RowSevenClick = 6;
            }
        }

        private void btn_Row1Slot_MouseHover(object sender, EventArgs e)
        {
            if (RowOneClick == 0)
            {
                btn_Row1Space1.BackColor = Color.Yellow;
            }
            else if (RowOneClick == 1)
            {
                btn_Row1Space2.BackColor = Color.Yellow;
            }
            else if (RowOneClick == 2)
            {
                btn_Row1Space3.BackColor = Color.Yellow;
            }
            else if (RowOneClick == 3)
            {
                btn_Row1Space4.BackColor = Color.Yellow;
            }
            else if (RowOneClick == 4)
            {
                btn_Row1Space5.BackColor = Color.Yellow;
            }
            else if (RowOneClick == 5)
            {
                btn_Row1Space6.BackColor = Color.Yellow;
            }
        }

        private void btn_Row1Slot_MouseLeave(object sender, EventArgs e)
        {
            if (RowOneClick == 0)
            {
                btn_Row1Space1.BackColor = Color.White;
            }
            else if (RowOneClick == 1)
            {
                btn_Row1Space2.BackColor = Color.White;
            }
            else if (RowOneClick == 2)
            {
                btn_Row1Space3.BackColor = Color.White;
            }
            else if (RowOneClick == 3)
            {
                btn_Row1Space4.BackColor = Color.White;
            }
            else if (RowOneClick == 4)
            {
                btn_Row1Space5.BackColor = Color.White;
            }
            else if (RowOneClick == 5)
            {
                btn_Row1Space6.BackColor = Color.White;
            }
        }

        private void btn_Row2Slot_MouseHover(object sender, EventArgs e)
        {
            if (RowTwoClick == 0)
            {
                btn_Row2Space1.BackColor = Color.Yellow;
            }
            else if (RowTwoClick == 1)
            {
                btn_Row2Space2.BackColor = Color.Yellow;
            }
            else if (RowTwoClick == 2)
            {
                btn_Row2Space3.BackColor = Color.Yellow;
            }
            else if (RowTwoClick == 3)
            {
                btn_Row2Space4.BackColor = Color.Yellow;
            }
            else if (RowTwoClick == 4)
            {
                btn_Row2Space5.BackColor = Color.Yellow;
            }
            else if (RowTwoClick == 5)
            {
                btn_Row2Space6.BackColor = Color.Yellow;
            }
        }

        private void btn_Row3Slot_MouseHover(object sender, EventArgs e)
        {
            if (RowThreeClick == 0)
            {
                btn_Row3Space1.BackColor = Color.Yellow;
            }
            else if (RowThreeClick == 1)
            {
                btn_Row3Space2.BackColor = Color.Yellow;
            }
            else if (RowThreeClick == 2)
            {
                btn_Row3Space3.BackColor = Color.Yellow;
            }
            else if (RowThreeClick == 3)
            {
                btn_Row3Space4.BackColor = Color.Yellow;
            }
            else if (RowThreeClick == 4)
            {
                btn_Row3Space5.BackColor = Color.Yellow;
            }
            else if (RowThreeClick == 5)
            {
                btn_Row3Space6.BackColor = Color.Yellow;
            }
        }

        private void btn_Row4Slot_MouseHover(object sender, EventArgs e)
        {
            if (RowFourClick == 0)
            {
                btn_Row4Space1.BackColor = Color.Yellow;
            }
            else if (RowFourClick == 1)
            {
                btn_Row4Space2.BackColor = Color.Yellow;
            }
            else if (RowFourClick == 2)
            {
                btn_Row4Space3.BackColor = Color.Yellow;
            }
            else if (RowFourClick == 3)
            {
                btn_Row4Space4.BackColor = Color.Yellow;
            }
            else if (RowFourClick == 4)
            {
                btn_Row4Space5.BackColor = Color.Yellow;
            }
            else if (RowFourClick == 5)
            {
                btn_Row4Space6.BackColor = Color.Yellow;
            }
        }

        private void btn_Row5Slot_MouseHover(object sender, EventArgs e)
        {
            if (RowFiveClick == 0)
            {
                btn_Row5Space1.BackColor = Color.Yellow;
            }
            else if (RowFiveClick == 1)
            {
                btn_Row5Space2.BackColor = Color.Yellow;
            }
            else if (RowFiveClick == 2)
            {
                btn_Row5Space3.BackColor = Color.Yellow;
            }
            else if (RowFiveClick == 3)
            {
                btn_Row5Space4.BackColor = Color.Yellow;
            }
            else if (RowFiveClick == 4)
            {
                btn_Row5Space5.BackColor = Color.Yellow;
            }
            else if (RowFiveClick == 5)
            {
                btn_Row5Space6.BackColor = Color.Yellow;
            }
        }

        private void btn_Row6Slot_MouseHover(object sender, EventArgs e)
        {
            if (RowSixClick == 0)
            {
                btn_Row6Space1.BackColor = Color.Yellow;
            }
            else if (RowSixClick == 1)
            {
                btn_Row6Space2.BackColor = Color.Yellow;
            }
            else if (RowSixClick == 2)
            {
                btn_Row6Space3.BackColor = Color.Yellow;
            }
            else if (RowSixClick == 3)
            {
                btn_Row6Space4.BackColor = Color.Yellow;
            }
            else if (RowSixClick == 4)
            {
                btn_Row6Space5.BackColor = Color.Yellow;
            }
            else if (RowSixClick == 5)
            {
                btn_Row6Space6.BackColor = Color.Yellow;
            }
        }

        private void btn_Row7Slot_MouseHover(object sender, EventArgs e)
        {
            if (RowSevenClick == 0)
            {
                btn_Row7Space1.BackColor = Color.Yellow;
            }
            else if (RowSevenClick == 1)
            {
                btn_Row7Space2.BackColor = Color.Yellow;
            }
            else if (RowSevenClick == 2)
            {
                btn_Row7Space3.BackColor = Color.Yellow;
            }
            else if (RowSevenClick == 3)
            {
                btn_Row7Space4.BackColor = Color.Yellow;
            }
            else if (RowSevenClick == 4)
            {
                btn_Row7Space5.BackColor = Color.Yellow;
            }
            else if (RowSevenClick == 5)
            {
                btn_Row7Space6.BackColor = Color.Yellow;
            }
        }

        private void btn_Row2Slot_MouseLeave(object sender, EventArgs e)
        {
            if (RowTwoClick == 0)
            {
                btn_Row2Space1.BackColor = Color.White;
            }
            else if (RowTwoClick == 1)
            {
                btn_Row2Space2.BackColor = Color.White;
            }
            else if (RowTwoClick == 2)
            {
                btn_Row2Space3.BackColor = Color.White;
            }
            else if (RowTwoClick == 3)
            {
                btn_Row2Space4.BackColor = Color.White;
            }
            else if (RowTwoClick == 4)
            {
                btn_Row2Space5.BackColor = Color.White;
            }
            else if (RowTwoClick == 5)
            {
                btn_Row2Space6.BackColor = Color.White;
            }
        }

        private void btn_Row3Slot_MouseLeave(object sender, EventArgs e)
        {
            if (RowThreeClick == 0)
            {
                btn_Row3Space1.BackColor = Color.White;
            }
            else if (RowThreeClick == 1)
            {
                btn_Row3Space2.BackColor = Color.White;
            }
            else if (RowThreeClick == 2)
            {
                btn_Row3Space3.BackColor = Color.White;
            }
            else if (RowThreeClick == 3)
            {
                btn_Row3Space4.BackColor = Color.White;
            }
            else if (RowThreeClick == 4)
            {
                btn_Row3Space5.BackColor = Color.White;
            }
            else if (RowThreeClick == 5)
            {
                btn_Row3Space6.BackColor = Color.White;
            }
        }

        private void btn_Row4Slot_MouseLeave(object sender, EventArgs e)
        {
            if (RowFourClick == 0)
            {
                btn_Row4Space1.BackColor = Color.White;
            }
            else if (RowFourClick == 1)
            {
                btn_Row4Space2.BackColor = Color.White;
            }
            else if (RowFourClick == 2)
            {
                btn_Row4Space3.BackColor = Color.White;
            }
            else if (RowFourClick == 3)
            {
                btn_Row4Space4.BackColor = Color.White;
            }
            else if (RowFourClick == 4)
            {
                btn_Row4Space5.BackColor = Color.White;
            }
            else if (RowFourClick == 5)
            {
                btn_Row4Space6.BackColor = Color.White;
            }
        }

        private void btn_Row5Slot_MouseLeave(object sender, EventArgs e)
        {
            if (RowFiveClick == 0)
            {
                btn_Row5Space1.BackColor = Color.White;
            }
            else if (RowFiveClick == 1)
            {
                btn_Row5Space2.BackColor = Color.White;
            }
            else if (RowFiveClick == 2)
            {
                btn_Row5Space3.BackColor = Color.White;
            }
            else if (RowFiveClick == 3)
            {
                btn_Row5Space4.BackColor = Color.White;
            }
            else if (RowFiveClick == 4)
            {
                btn_Row5Space5.BackColor = Color.White;
            }
            else if (RowFiveClick == 5)
            {
                btn_Row5Space6.BackColor = Color.White;
            }
        }

        private void btn_Row6Slot_MouseLeave(object sender, EventArgs e)
        {
            if (RowSixClick == 0)
            {
                btn_Row6Space1.BackColor = Color.White;
            }
            else if (RowSixClick == 1)
            {
                btn_Row6Space2.BackColor = Color.White;
            }
            else if (RowSixClick == 2)
            {
                btn_Row6Space3.BackColor = Color.White;
            }
            else if (RowSixClick == 3)
            {
                btn_Row6Space4.BackColor = Color.White;
            }
            else if (RowSixClick == 4)
            {
                btn_Row6Space5.BackColor = Color.White;
            }
            else if (RowSixClick == 5)
            {
                btn_Row6Space6.BackColor = Color.White;
            }
        }

        private void btn_Row7Slot_MouseLeave(object sender, EventArgs e)
        {
            if (RowSevenClick == 0)
            {
                btn_Row7Space1.BackColor = Color.White;
            }
            else if (RowSevenClick == 1)
            {
                btn_Row7Space2.BackColor = Color.White;
            }
            else if (RowSevenClick == 2)
            {
                btn_Row7Space3.BackColor = Color.White;
            }
            else if (RowSevenClick == 3)
            {
                btn_Row7Space4.BackColor = Color.White;
            }
            else if (RowSevenClick == 4)
            {
                btn_Row7Space5.BackColor = Color.White;
            }
            else if (RowSevenClick == 5)
            {
                btn_Row7Space6.BackColor = Color.White;
            }
        }
    }
}
