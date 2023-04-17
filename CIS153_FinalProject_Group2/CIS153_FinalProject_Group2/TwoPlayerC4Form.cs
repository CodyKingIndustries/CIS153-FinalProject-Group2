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

//  placing a disc at the top, will overide the other players disc -> this needs to be fixed



namespace CIS153_FinalProject_Group2
{
    public partial class TwoPlayerC4Form : Form
    {
        private MainMenuForm MainScreenForm;
        private Board TPBoard = new Board();
        //  bool to track which players turn it is
        private bool playerOnesTurn = true;
        //To get hover feature (Could also use it for actually placing discs, but I went for a more dynamic approach)
        private int col0Clicks = 0;
        private int col1Clicks = 0;
        private int col2Clicks = 0;
        private int col3Clicks = 0;
        private int col4Clicks = 0;
        private int col5Clicks = 0;
        private int col6Clicks = 0;
        //Will use modulus to track who's turn it is (even vs odd)
        private int totalClicks = 0;
        private bool hasWinner = false;


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
        //starting with column 0 (to 6). It will drop a disc as far down as possible (as long as the cell below it isn't occupied)
        //COLUMN 0 SLOT CLICK =================================================================


        private void btn_Col0Slot_Click(object sender, EventArgs e)
        {


            col0Clicks++;
            int r = 5;
            int c = 0;

            if (totalClicks % 2 == 0)
            {
                playerOnesTurn = true;
                txt_playerTurn.Text = "Turn: Player 2";
            }
            else
            {
                playerOnesTurn = false;
                txt_playerTurn.Text = "Turn: Player 1";
            }

            
            while (TPBoard.getBoard()[r, c].isFull() == true && r != 0)
            {
                r--;
            }

            //There's going to be a LOT of lines of code but it's all really simple
            //There's really no way to shorten it down with a loop since you can't
            //access a button using it's name and some variables such as accessing
            //btn_02 using a variable with 0 and another with 2. It just doesn't work
            //I also wanted to make this as dynamic as possible which can also be helpful
            //when passing the position of the last placed disc to the function to check for a winner
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
            hasWinner = TPBoard.checkWinner(r, c);
            ifWinner();

            totalClicks++;
        }

        //COLUMN 1 SLOT CLICK =================================================================
        private void btn_Col1Slot_Click(object sender, EventArgs e)
        {


            col1Clicks++;
            int r = 5;
            int c = 1;

            if (totalClicks % 2 == 0)
            {
                playerOnesTurn = true;
                txt_playerTurn.Text = "Turn: Player 2";
            }
            else
            {
                playerOnesTurn = false;
                txt_playerTurn.Text = "Turn: Player 1";
            }

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
            hasWinner = TPBoard.checkWinner(r, c);
            ifWinner();
            totalClicks++;



        }

        //COLUMN 2 SLOT CLICK =================================================================
        private void btn_Col2Slot_Click(object sender, EventArgs e)
        {

            col2Clicks++;
            int r = 5;
            int c = 2;

            if (totalClicks % 2 == 0)
            {
                playerOnesTurn = true;
                txt_playerTurn.Text = "Turn: Player 2";
            }
            else
            {
                playerOnesTurn = false;
                txt_playerTurn.Text = "Turn: Player 1";
            }

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
            hasWinner = TPBoard.checkWinner(r, c);
            ifWinner();
            totalClicks++;


        }

        //COLUMN 3 SLOT CLICK =================================================================
        private void btn_Col3Slot_Click(object sender, EventArgs e)
        {
            col3Clicks++;
            int r = 5;
            int c = 3;

            if (totalClicks % 2 == 0)
            {
                playerOnesTurn = true;
                txt_playerTurn.Text = "Turn: Player 2";
            }
            else
            {
                playerOnesTurn = false;
                txt_playerTurn.Text = "Turn: Player 1";
            }

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
            hasWinner = TPBoard.checkWinner(r, c);
            ifWinner();
            totalClicks++;
        }

        //COLUMN 4 SLOT CLICK =================================================================
        private void btn_Col4Slot_Click(object sender, EventArgs e)
        {
            col4Clicks++;
            int r = 5;
            int c = 4;

            if (totalClicks % 2 == 0)
            {
                playerOnesTurn = true;
                txt_playerTurn.Text = "Turn: Player 2";
            }
            else
            {
                playerOnesTurn = false;
                txt_playerTurn.Text = "Turn: Player 1";
            }

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
            hasWinner = TPBoard.checkWinner(r, c);
            ifWinner();
            totalClicks++;
        }

        //COLUMN 5 SLOT CLICK =================================================================
        private void btn_Col5Slot_Click(object sender, EventArgs e)
        {
            col5Clicks++;
            int r = 5;
            int c = 5;

            if (totalClicks % 2 == 0)
            {
                playerOnesTurn = true;
                txt_playerTurn.Text = "Turn: Player 2";
            }
            else
            {
                playerOnesTurn = false;
                txt_playerTurn.Text = "Turn: Player 1";
            }

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
            hasWinner = TPBoard.checkWinner(r, c);
            ifWinner();
            totalClicks++;
        }

        //COLUMN 6 SLOT CLICK =================================================================
        private void btn_Col6Slot_Click(object sender, EventArgs e)
        {
            col6Clicks++;
            int r = 5;
            int c = 6;

            if (totalClicks % 2 == 0)
            {
                playerOnesTurn = true;
                txt_playerTurn.Text = "Turn: Player 2";
            }
            else
            {
                playerOnesTurn = false;
                txt_playerTurn.Text = "Turn: Player 1";
            }

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
            hasWinner = TPBoard.checkWinner(r, c);
            ifWinner();
            totalClicks++;
        }


        //MOUSE HOVERS
        private void btn_Col0Slot_MouseHover(object sender, EventArgs e)
        {
            if(col0Clicks == 0)
            {
                if(totalClicks == 0)
                {
                    btn_50.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_50.BackColor = Color.Pink;
                }
                else
                {
                    btn_50.BackColor = Color.LightYellow;
                }
            }
            else if (col0Clicks == 1)
            {
                if (totalClicks == 0)
                {
                    btn_40.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_40.BackColor = Color.Pink;
                }
                else
                {
                    btn_40.BackColor = Color.LightYellow;
                }
            }
            else if (col0Clicks == 2)
            {
                if (totalClicks == 0)
                {
                    btn_30.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_30.BackColor = Color.Pink;
                }
                else
                {
                    btn_30.BackColor = Color.LightYellow;
                }
            }
            else if (col0Clicks == 3)
            {
                if (totalClicks == 0)
                {
                    btn_20.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_20.BackColor = Color.Pink;
                }
                else
                {
                    btn_20.BackColor = Color.LightYellow;
                }
            }
            else if (col0Clicks == 4)
            {
                if (totalClicks == 0)
                {
                    btn_10.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_10.BackColor = Color.Pink;
                }
                else
                {
                    btn_10.BackColor = Color.LightYellow;
                }
            }
            else if (col0Clicks == 5)
            {
                if (totalClicks == 0)
                {
                    btn_00.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_00.BackColor = Color.Pink;
                }
                else
                {
                    btn_00.BackColor = Color.LightYellow;
                }
            }
        }


        private void btn_Col1Slot_MouseHover(object sender, EventArgs e)
        {
            if (col1Clicks == 0)
            {
                if (totalClicks == 0)
                {
                    btn_51.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_51.BackColor = Color.Pink;
                }
                else 
                {
                    btn_51.BackColor = Color.LightYellow;
                }
            }
            else if (col1Clicks == 1)
            {
                if (totalClicks == 0)
                {
                    btn_41.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_41.BackColor = Color.Pink;
                }
                else 
                {
                    btn_41.BackColor = Color.LightYellow;
                }
            }
            else if (col1Clicks == 2)
            {
                if (totalClicks == 0)
                {
                    btn_31.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_31.BackColor = Color.Pink;
                }
                else
                {
                    btn_31.BackColor = Color.LightYellow;
                }
            }
            else if (col1Clicks == 3)
            {
                if (totalClicks == 0)
                {
                    btn_21.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_21.BackColor = Color.Pink;
                }
                else
                {
                    btn_21.BackColor = Color.LightYellow;
                }
            }
            else if (col1Clicks == 4)
            {
                if (totalClicks == 0)
                {
                    btn_11.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_11.BackColor = Color.Pink;
                }
                else
                {
                    btn_11.BackColor = Color.LightYellow;
                }
            }
            else if (col1Clicks == 5)
            {
                if (totalClicks == 0)
                {
                    btn_01.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_01.BackColor = Color.Pink;
                }
                else
                {
                    btn_01.BackColor = Color.LightYellow;
                }
            }
        }

        private void btn_Col2Slot_MouseHover(object sender, EventArgs e)
        {
            if (col2Clicks == 0)
            {
                if (totalClicks == 0)
                {
                    btn_52.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_52.BackColor = Color.Pink;
                }
                else
                {
                    btn_52.BackColor = Color.LightYellow;
                }
            }
            else if (col2Clicks == 1)
            {
                if (totalClicks == 0)
                {
                    btn_42.BackColor = Color.Pink;
                }
                else if(playerOnesTurn == false)
                {
                    btn_42.BackColor = Color.Pink;
                }
                else
                {
                    btn_42.BackColor = Color.LightYellow;
                }
            }
            else if (col2Clicks == 2)
            {
                if (totalClicks == 0)
                {
                    btn_32.BackColor = Color.Pink;
                }
                else if(playerOnesTurn == false)
                {
                    btn_32.BackColor = Color.Pink;
                }
                else
                {
                    btn_32.BackColor = Color.LightYellow;
                }
            }
            else if (col2Clicks == 3)
            {
                if (totalClicks == 0)
                {
                    btn_22.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_22.BackColor = Color.Pink;
                }
                else
                {
                    btn_22.BackColor = Color.LightYellow;
                }
            }
            else if (col2Clicks == 4)
            {
                if (totalClicks == 0)
                {
                    btn_12.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_12.BackColor = Color.Pink;
                }
                else
                {
                    btn_12.BackColor = Color.LightYellow;
                }
            }
            else if (col2Clicks == 5)
            {
                if (totalClicks == 0)
                {
                    btn_02.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_02.BackColor = Color.Pink;
                }
                else
                {
                    btn_02.BackColor = Color.LightYellow;
                }
            }
        }

        private void btn_Col3Slot_MouseHover(object sender, EventArgs e)
        {
            if (col3Clicks == 0)
            {
                if (totalClicks == 0)
                {
                    btn_53.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_53.BackColor = Color.Pink;
                }
                else
                {
                    btn_53.BackColor = Color.LightYellow;
                }
            }
            else if (col3Clicks == 1)
            {
                if (totalClicks == 0)
                {
                    btn_43.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_43.BackColor = Color.Pink;
                }
                else
                {
                    btn_43.BackColor = Color.LightYellow;
                }
            }
            else if (col3Clicks == 2)
            {
                if (totalClicks == 0)
                {
                    btn_33.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_33.BackColor = Color.Pink;
                }
                else
                {
                    btn_33.BackColor = Color.LightYellow;
                }
            }
            else if (col3Clicks == 3)
            {
                if (totalClicks == 0)
                {
                    btn_23.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_23.BackColor = Color.Pink;
                }
                else
                {
                    btn_23.BackColor = Color.LightYellow;
                }
            }
            else if (col3Clicks == 4)
            {
                if (totalClicks == 0)
                {
                    btn_13.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_13.BackColor = Color.Pink;
                }
                else
                {
                    btn_13.BackColor = Color.LightYellow;
                }
            }
            else if (col3Clicks == 5)
            {
                if (totalClicks == 0)
                {
                    btn_03.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_03.BackColor = Color.Pink;
                }
                else
                {
                    btn_03.BackColor = Color.LightYellow;
                }
            }
        }

        private void btn_Col4Slot_MouseHover(object sender, EventArgs e)
        {
            if (col4Clicks == 0)
            {
                if (totalClicks == 0)
                {
                    btn_54.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_54.BackColor = Color.Pink;
                }
                else
                {
                    btn_54.BackColor = Color.LightYellow;
                }
            }
            else if (col4Clicks == 1)
            {
                if (totalClicks == 0)
                {
                    btn_44.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_44.BackColor = Color.Pink;
                }
                else
                {
                    btn_44.BackColor = Color.LightYellow;
                }
            }
            else if (col4Clicks == 2)
            {
                if (totalClicks == 0)
                {
                    btn_34.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_34.BackColor = Color.Pink;
                }
                else
                {
                    btn_34.BackColor = Color.LightYellow;
                }
            }
            else if (col4Clicks == 3)
            {
                if (totalClicks == 0)
                {
                    btn_24.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_24.BackColor = Color.Pink;
                }
                else
                {
                    btn_24.BackColor = Color.LightYellow;
                }
            }
            else if (col4Clicks == 4)
            {
                if (totalClicks == 0)
                {
                    btn_14.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_14.BackColor = Color.Pink;
                }
                else
                {
                    btn_14.BackColor = Color.LightYellow;
                }
            }
            else if (col4Clicks == 5)
            {
                if (totalClicks == 0)
                {
                    btn_04.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_04.BackColor = Color.Pink;
                }
                else
                {
                    btn_04.BackColor = Color.LightYellow;
                }
            }
        }

        private void btn_Col5Slot_MouseHover(object sender, EventArgs e)
        {
            if (col5Clicks == 0)
            {
                if (totalClicks == 0)
                {
                    btn_55.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_55.BackColor = Color.Pink;
                }
                else
                {
                    btn_55.BackColor = Color.LightYellow;
                }
            }
            else if (col5Clicks == 1)
            {
                if (totalClicks == 0)
                {
                    btn_45.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_45.BackColor = Color.Pink;
                }
                else
                {
                    btn_45.BackColor = Color.LightYellow;
                }
            }
            else if (col5Clicks == 2)
            {
                if (totalClicks == 0)
                {
                    btn_35.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_35.BackColor = Color.Pink;
                }
                else
                {
                    btn_35.BackColor = Color.LightYellow;
                }
            }
            else if (col5Clicks == 3)
            {
                if (totalClicks == 0)
                {
                    btn_25.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_25.BackColor = Color.Pink;
                }
                else
                {
                    btn_25.BackColor = Color.LightYellow;
                }
            }
            else if (col5Clicks == 4)
            {
                if (totalClicks == 0)
                {
                    btn_15.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_15.BackColor = Color.Pink;
                }
                else
                {
                    btn_15.BackColor = Color.LightYellow;
                }
            }
            else if (col5Clicks == 5)
            {
                if (totalClicks == 0)
                {
                    btn_05.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_05.BackColor = Color.Pink;
                }
                else
                {
                    btn_05.BackColor = Color.LightYellow;
                }
            }
        }

        private void btn_Col6Slot_MouseHover(object sender, EventArgs e)
        {
            if (col6Clicks == 0)
            {
                if (totalClicks == 0)
                {
                    btn_56.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_56.BackColor = Color.Pink;
                }
                else
                {
                    btn_56.BackColor = Color.LightYellow;
                };
            }
            else if (col6Clicks == 1)
            {
                if (totalClicks == 0)
                {
                    btn_46.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_46.BackColor = Color.Pink;
                }
                else
                {
                    btn_46.BackColor = Color.LightYellow;
                }
            }
            else if (col6Clicks == 2)
            {
                if (totalClicks == 0)
                {
                    btn_36.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_36.BackColor = Color.Pink;
                }
                else
                {
                    btn_36.BackColor = Color.LightYellow;
                }
            }
            else if (col6Clicks == 3)
            {
                if (totalClicks == 0)
                {
                    btn_26.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_26.BackColor = Color.Pink;
                }
                else
                {
                    btn_26.BackColor = Color.LightYellow;
                }
            }
            else if (col6Clicks == 4)
            {
                if (totalClicks == 0)
                {
                    btn_16.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_16.BackColor = Color.Pink;
                }
                else
                {
                    btn_16.BackColor = Color.LightYellow;
                }
            }
            else if (col6Clicks == 5)
            {
                if (totalClicks == 0)
                {
                    btn_06.BackColor = Color.Pink;
                }
                else if (playerOnesTurn == false)
                {
                    btn_06.BackColor = Color.Pink;
                }
                else
                {
                    btn_06.BackColor = Color.LightYellow;
                }
            }
        }


        //MOUSE LEAVE
        private void btn_Col0Slot_MouseLeave(object sender, EventArgs e)
        {
            if (col0Clicks == 0)
            {
                btn_50.BackColor = Color.White;
            }
            else if (col0Clicks == 1)
            {
                btn_40.BackColor = Color.White;
            }
            else if (col0Clicks == 2)
            {
                btn_30.BackColor = Color.White;
            }
            else if (col0Clicks == 3)
            {
                btn_20.BackColor = Color.White;
            }
            else if (col0Clicks == 4)
            {
                btn_10.BackColor = Color.White;
            }
            else if (col0Clicks == 5)
            {
                btn_00.BackColor = Color.White;
            }
        }

        private void btn_Col1Slot_MouseLeave(object sender, EventArgs e)
        {
            if (col1Clicks == 0)
            {
                btn_51.BackColor = Color.White;
            }
            else if (col1Clicks == 1)
            {
                btn_41.BackColor = Color.White;
            }
            else if (col1Clicks == 2)
            {
                btn_31.BackColor = Color.White;
            }
            else if (col1Clicks == 3)
            {
                btn_21.BackColor = Color.White;
            }
            else if (col1Clicks == 4)
            {
                btn_11.BackColor = Color.White;
            }
            else if (col1Clicks == 5)
            {
                btn_01.BackColor = Color.White;
            }
        }

        private void btn_Col2Slot_MouseLeave(object sender, EventArgs e)
        {
            if (col2Clicks == 0)
            {
                btn_52.BackColor = Color.White;
            }
            else if (col2Clicks == 1)
            {
                btn_42.BackColor = Color.White;
            }
            else if (col2Clicks == 2)
            {
                btn_32.BackColor = Color.White;
            }
            else if (col2Clicks == 3)
            {
                btn_22.BackColor = Color.White;
            }
            else if (col2Clicks == 4)
            {
                btn_12.BackColor = Color.White;
            }
            else if (col2Clicks == 5)
            {
                btn_02.BackColor = Color.White;
            }
        }

        private void btn_Col3Slot_MouseLeave(object sender, EventArgs e)
        {
            if (col3Clicks == 0)
            {
                btn_53.BackColor = Color.White;
            }
            else if (col3Clicks == 1)
            {
                btn_43.BackColor = Color.White;
            }
            else if (col3Clicks == 2)
            {
                btn_33.BackColor = Color.White;
            }
            else if (col3Clicks == 3)
            {
                btn_23.BackColor = Color.White;
            }
            else if (col3Clicks == 4)
            {
                btn_13.BackColor = Color.White;
            }
            else if (col3Clicks == 5)
            {
                btn_03.BackColor = Color.White;
            }
        }

        private void btn_Col4Slot_MouseLeave(object sender, EventArgs e)
        {
            if (col4Clicks == 0)
            {
                btn_54.BackColor = Color.White;
            }
            else if (col4Clicks == 1)
            {
                btn_44.BackColor = Color.White;
            }
            else if (col4Clicks == 2)
            {
                btn_34.BackColor = Color.White;
            }
            else if (col4Clicks == 3)
            {
                btn_24.BackColor = Color.White;
            }
            else if (col4Clicks == 4)
            {
                btn_14.BackColor = Color.White;
            }
            else if (col4Clicks == 5)
            {
                btn_04.BackColor = Color.White;
            }
        }

        private void btn_Col5Slot_MouseLeave(object sender, EventArgs e)
        {
            if (col5Clicks == 0)
            {
                btn_55.BackColor = Color.White;
            }
            else if (col5Clicks == 1)
            {
                btn_45.BackColor = Color.White;
            }
            else if (col5Clicks == 2)
            {
                btn_35.BackColor = Color.White;
            }
            else if (col5Clicks == 3)
            {
                btn_25.BackColor = Color.White;
            }
            else if (col5Clicks == 4)
            {
                btn_15.BackColor = Color.White;
            }
            else if (col5Clicks == 5)
            {
                btn_05.BackColor = Color.White;
            }
        }

        private void btn_Col6Slot_MouseLeave(object sender, EventArgs e)
        {
            if (col6Clicks == 0)
            {
                btn_56.BackColor = Color.White;
            }
            else if (col6Clicks == 1)
            {
                btn_46.BackColor = Color.White;
            }
            else if (col6Clicks == 2)
            {
                btn_36.BackColor = Color.White;
            }
            else if (col6Clicks == 3)
            {
                btn_26.BackColor = Color.White;
            }
            else if (col6Clicks == 4)
            {
                btn_16.BackColor = Color.White;
            }
            else if (col6Clicks == 5)
            {
                btn_06.BackColor = Color.White;
            }
        }

        //IF WINNER
        private void ifWinner()
        {
            if (hasWinner)
            {
                if (playerOnesTurn)
                {
                    txt_playerTurn.Text = "Player 1 Wins!";
                }
                else
                {
                    txt_playerTurn.Text = "Player 2 Wins!";
                }
                btn_Col0Slot.Enabled = false;
                btn_Col1Slot.Enabled = false;
                btn_Col2Slot.Enabled = false;
                btn_Col3Slot.Enabled = false;
                btn_Col4Slot.Enabled = false;
                btn_Col5Slot.Enabled = false;
                btn_Col6Slot.Enabled = false;
            }
        }

        //BOTTOM BUTTONS
        private void btn_loadMainScreen_Click(object sender, EventArgs e)
        {
            this.Close();
            MainScreenForm.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
