using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject_Group2
{
    public partial class TwoPlayerC4Form : Form
    {
        private MainMenuForm MainScreenForm;
        private Board TPBoard = new Board();
        //  bool to track which players turn it is
        private bool playerOnesTurn = true;


        private void TwoPlayerC4Form_Load(object sender, EventArgs e)
        {

        }
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
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            //  upon entering, load the connect 4 board
            TPBoard = new Board();
        }


        //upon clicking the purple square at the top, it will "drop a disc" down that respective column
        //starting with column 0. It will drop a disc as far down as possible (as long as the cell below it isn't occupied)
        //COLUMN 0 SLOT CLICK =================================================================
        private void btn_Col0Slot_Click(object sender, EventArgs e)
        {
            int r = 5;
            int c = 0;

            while (TPBoard.getBoard()[r, c].isFull() == true && r != 0)
            {
                r--;
            }

            //There's going to be a LOT of lines of code but it's all really simple
            //There's really no way to shorten it down with a loop since you can't
            //access a button using it's name and some variables
            TPBoard.getBoard()[r, c].placeDisc();
            if (r == 0)
            {
                if (playerOnesTurn)
                {
                    btn_00.BackColor = Color.Red;
                    //We can use the cell's color attribute as a way to check for the winner
                    //We can look for 4 cells in a row of the same color 
                    //ex: if (TPBoard.getBoard()[r,c].getCellColor() == the same as 3 more in a row), then we have a winner
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_00.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 1)
            {
                if (playerOnesTurn)
                {
                    btn_10.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_10.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 2)
            {
                if (playerOnesTurn)
                {
                    btn_20.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_20.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 3)
            {
                if (playerOnesTurn)
                {
                    btn_30.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_30.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 4)
            {
                if (playerOnesTurn)
                {
                    btn_40.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_40.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 5)
            {
                if (playerOnesTurn)
                {
                    btn_50.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_50.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
        }

        //COLUMN 1 SLOT CLICK =================================================================
        private void btn_Col1Slot_Click(object sender, EventArgs e)
        {
            int r = 5;
            int c = 1;

            while (TPBoard.getBoard()[r, c].isFull() == true && r != 0)
            {
                r--;
            }

            TPBoard.getBoard()[r, c].placeDisc();
            if (r == 0)
            {
                if (playerOnesTurn)
                {
                    btn_01.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_01.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 1)
            {
                if (playerOnesTurn)
                {
                    btn_11.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_11.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 2)
            {
                if (playerOnesTurn)
                {
                    btn_21.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_21.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 3)
            {
                if (playerOnesTurn)
                {
                    btn_31.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_31.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 4)
            {
                if (playerOnesTurn)
                {
                    btn_41.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_41.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 5)
            {
                if (playerOnesTurn)
                {
                    btn_51.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_51.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
        }

        //COLUMN 2 SLOT CLICK =================================================================
        private void btn_Col2Slot_Click(object sender, EventArgs e)
        {
            int r = 5;
            int c = 2;

            while (TPBoard.getBoard()[r, c].isFull() == true && r != 0)
            {
                r--;
            }

            TPBoard.getBoard()[r, c].placeDisc(); 
            if (r == 0)
            {
                if (playerOnesTurn)
                {
                    btn_02.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_02.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 1)
            {
                if (playerOnesTurn)
                {
                    btn_12.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_12.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 2)
            {
                if (playerOnesTurn)
                {
                    btn_22.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_22.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 3)
            {
                if (playerOnesTurn)
                {
                    btn_32.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_32.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 4)
            {
                if (playerOnesTurn)
                {
                    btn_42.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_42.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 5)
            {
                if (playerOnesTurn)
                {
                    btn_52.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_52.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
        }

        //COLUMN 3 SLOT CLICK =================================================================
        private void btn_Col3Slot_Click(object sender, EventArgs e)
        {
            int r = 5;
            int c = 3;

            while (TPBoard.getBoard()[r, c].isFull() == true && r != 0)
            {
                r--;
            }

            TPBoard.getBoard()[r, c].placeDisc(); 
            if (r == 0)
            {
                if (playerOnesTurn)
                {
                    btn_03.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_03.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 1)
            {
                if (playerOnesTurn)
                {
                    btn_13.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_13.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 2)
            {
                if (playerOnesTurn)
                {
                    btn_23.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_23.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 3)
            {
                if (playerOnesTurn)
                {
                    btn_33.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_33.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 4)
            {
                if (playerOnesTurn)
                {
                    btn_43.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_43.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 5)
            {
                if (playerOnesTurn)
                {
                    btn_53.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_53.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
        }

        //COLUMN 4 SLOT CLICK =================================================================
        private void btn_Col4Slot_Click(object sender, EventArgs e)
        {
            int r = 5;
            int c = 4;

            while (TPBoard.getBoard()[r, c].isFull() == true && r != 0)
            {
                r--;
            }

            TPBoard.getBoard()[r, c].placeDisc(); 
            if (r == 0)
            {
                if (playerOnesTurn)
                {
                    btn_04.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_04.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 1)
            {
                if (playerOnesTurn)
                {
                    btn_14.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_14.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 2)
            {
                if (playerOnesTurn)
                {
                    btn_24.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_24.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 3)
            {
                if (playerOnesTurn)
                {
                    btn_34.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_34.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 4)
            {
                if (playerOnesTurn)
                {
                    btn_44.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_44.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 5)
            {
                if (playerOnesTurn)
                {
                    btn_54.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_54.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
        }

        //COLUMN 5 SLOT CLICK =================================================================
        private void btn_Col5Slot_Click(object sender, EventArgs e)
        {
            int r = 5;
            int c = 5;

            while (TPBoard.getBoard()[r, c].isFull() == true && r != 0)
            {
                r--;
            }

            TPBoard.getBoard()[r, c].placeDisc(); 
            if (r == 0)
            {
                if (playerOnesTurn)
                {
                    btn_05.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_05.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 1)
            {
                if (playerOnesTurn)
                {
                    btn_15.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_15.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 2)
            {
                if (playerOnesTurn)
                {
                    btn_25.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_25.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 3)
            {
                if (playerOnesTurn)
                {
                    btn_35.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_35.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 4)
            {
                if (playerOnesTurn)
                {
                    btn_45.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_45.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 5)
            {
                if (playerOnesTurn)
                {
                    btn_55.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_55.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
        }

        //COLUMN 6 SLOT CLICK =================================================================
        private void btn_Col6Slot_Click(object sender, EventArgs e)
        {
            int r = 5;
            int c = 6;

            while (TPBoard.getBoard()[r,c].isFull() == true && r != 0)
            {
                r--;
            }

            TPBoard.getBoard()[r, c].placeDisc(); 
            if (r == 0)
            {
                if (playerOnesTurn)
                {
                    btn_06.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_06.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 1)
            {
                if (playerOnesTurn)
                {
                    btn_16.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_16.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 2)
            {
                if (playerOnesTurn)
                {
                    btn_26.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_26.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 3)
            {
                if (playerOnesTurn)
                {
                    btn_36.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_36.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 4)
            {
                if (playerOnesTurn)
                {
                    btn_46.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_46.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
            else if (r == 5)
            {
                if (playerOnesTurn)
                {
                    btn_56.BackColor = Color.Red;
                    TPBoard.getBoard()[r, c].setCellColor("Red");
                }
                else
                {
                    btn_56.BackColor = Color.Yellow;
                    TPBoard.getBoard()[r, c].setCellColor("Yellow");
                }
            }
        }

        private void btn_loadMainScreen_Click(object sender, EventArgs e)
        {
            this.Close();
            MainScreenForm.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //============================================================
        //Might still need this, but probably not - Gabriel Ball
        //int r = 0;
        //while (TPBoard.getCell(r + 1, c).isFull() == false && r < 4)
        //{
        //    r++;
        //}
        //if (r == 4)
        //{
        //    r = 5;
        //}
        //=============================================================

    }
}
