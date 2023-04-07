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
        private Board TwoPlayerBoard = new Board();
        //  bool to track which players turn it is
        private bool playerOnesTurn = true;

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
            TwoPlayerBoard = new Board();
            //  display the board to see it
            displayTwoPlayerC4Board();
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

        //  Temporary button to insert a piece at the colum in the provided text box
        private void btn_TPC4F_tempPlacePiece_Click(object sender, EventArgs e)
        {
            
           

            if (playerOnesTurn == true)
            {
                TwoPlayerBoard.PlaceDisc(Int32.Parse(txtbox_TPC4F_ColumSelector.Text), "Red");
                playerOnesTurn = false;
            }
            else if (playerOnesTurn == false)
            {
                TwoPlayerBoard.PlaceDisc(Int32.Parse(txtbox_TPC4F_ColumSelector.Text), "Yellow");
                playerOnesTurn = true;
            }

            
            displayTwoPlayerC4Board();
        }

        //  This funciton simply re-displays the active board state in "color (#,#)"
        private void displayTwoPlayerC4Board()
        {
            //  This temporarily displays the Board state in "color (Col,Row)" format
            lbl_TPC4F_TempBoardDisplay.Text = "";
            for (int rows = 0; rows < 6; rows++)
            {
                for (int cols = 0; cols < 7; cols++)
                {
                    lbl_TPC4F_TempBoardDisplay.Text = lbl_TPC4F_TempBoardDisplay.Text + TwoPlayerBoard.getBoard()[rows, cols].getCellColor().ToString() + "(" + rows + "," + cols + ") ";
                }
                lbl_TPC4F_TempBoardDisplay.Text = lbl_TPC4F_TempBoardDisplay.Text + "\n";
            }

        }

    }
}
