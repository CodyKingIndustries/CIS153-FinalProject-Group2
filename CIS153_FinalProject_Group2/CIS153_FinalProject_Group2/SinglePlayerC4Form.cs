using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//  sound requirements
using System.IO;
using System.Media;

namespace CIS153_FinalProject_Group2
{
    public partial class SinglePlayerC4Form : Form
    {
        //  this is a global reference to the Home Screen of Connect 4
        private MainMenuForm MainScreenForm;
        private Board SPBoard = new Board();
        //  This is to keep track if the purple button was clicked for the hover requirement
        private int RowOneClick = 0;
        private int RowTwoClick = 0;
        private int RowThreeClick = 0;
        private int RowFourClick = 0;
        private int RowFiveClick = 0;
        private int RowSixClick = 0;
        private int RowSevenClick = 0;
        Stream soundFileS;
        SoundPlayer playSoundS;

        public SinglePlayerC4Form()
        {
            InitializeComponent();

        }

        //  Initialize This Form
        public SinglePlayerC4Form(MainMenuForm m)
        {
            InitializeComponent();
            MainScreenForm = m;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            soundFileS = Properties.Resources.CoinShort;
            playSoundS = new SoundPlayer(soundFileS);
        }


        private void SinglePlayerC4Form_Load(object sender, EventArgs e)
        {

        }

        //  Return to Main Screen
        private void btn_SPC4_tempLoadForm_Click(object sender, EventArgs e)
        {
            MainScreenForm.Show();
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //  ====================================================
        //  BUTTON CLICK FUNCITONS
        private void btn_Row1Slot_Click(object sender, EventArgs e)
        {
            playSoundS.Play();
            RowOneClick++;
            int r = 5;
            int c = 0;

            //  find highest empty position
            while (SPBoard.getBoard()[r, c].isFull() == true && r != 0)
            {
                r--;
            }

            //  Display change
            if (RowOneClick == 1)
            {
                btn_Row1Space1.BackColor = Color.Red;
            }
            else if (RowOneClick == 2)
            {
                btn_Row1Space2.BackColor = Color.Red;
            }
            else if (RowOneClick == 3)
            {
                btn_Row1Space3.BackColor = Color.Red;
            }
            else if (RowOneClick == 4)
            {
                btn_Row1Space4.BackColor = Color.Red;
            }
            else if (RowOneClick == 5)
            {
                btn_Row1Space5.BackColor = Color.Red;
            }
            else if (RowOneClick == 6)
            {
                btn_Row1Space6.BackColor = Color.Red;
                btn_Row1Slot.Enabled = false;
            }

            SPBoard.getBoard()[r, c].placeDisc("Red");

            if (SPBoard.checkWinner(r, c))
            {
                EndGame(true);
            }
            else
            {
                AiDecision();
            }
        }

        private void btn_Row2Slot_Click(object sender, EventArgs e)
        {
            playSoundS.Play();
            RowTwoClick++;
            int r = 5;
            int c = 1;

            //  find highest empty position
            while (SPBoard.getBoard()[r, c].isFull() == true && r != 0)
            {
                r--;
            }

            if (RowTwoClick == 1)
            {
                btn_Row2Space1.BackColor = Color.Red;
            }
            else if (RowTwoClick == 2)
            {
                btn_Row2Space2.BackColor = Color.Red;
            }
            else if (RowTwoClick == 3)
            {
                btn_Row2Space3.BackColor = Color.Red;
            }
            else if (RowTwoClick == 4)
            {
                btn_Row2Space4.BackColor = Color.Red;
            }
            else if (RowTwoClick == 5)
            {
                btn_Row2Space5.BackColor = Color.Red;
            }
            else if (RowTwoClick == 6)
            {
                btn_Row2Space6.BackColor = Color.Red;
                btn_Row2Slot.Enabled = false;
            }

            SPBoard.getBoard()[r, c].placeDisc("Red");

            if (SPBoard.checkWinner(r, c))
            {
                EndGame(true);
            }
            else
            {
                AiDecision();
            }
        }

        private void btn_Row3Slot_Click(object sender, EventArgs e)
        {
            playSoundS.Play();
            RowThreeClick++;
            int r = 5;
            int c = 2;

            //  find highest empty position
            while (SPBoard.getBoard()[r, c].isFull() == true && r != 0)
            {
                r--;
            }

            if (RowThreeClick == 1)
            {
                btn_Row3Space1.BackColor = Color.Red;
            }
            else if (RowThreeClick == 2)
            {
                btn_Row3Space2.BackColor = Color.Red;
            }
            else if (RowThreeClick == 3)
            {
                btn_Row3Space3.BackColor = Color.Red;
            }
            else if (RowThreeClick == 4)
            {
                btn_Row3Space4.BackColor = Color.Red;
            }
            else if (RowThreeClick == 5)
            {
                btn_Row3Space5.BackColor = Color.Red;
            }
            else if (RowThreeClick == 6)
            {
                btn_Row3Space6.BackColor = Color.Red;
                btn_Row3Slot.Enabled = false;
            }
            SPBoard.getBoard()[r, c].placeDisc("Red");

            if (SPBoard.checkWinner(r, c))
            {
                EndGame(true);
            }
            else
            {
                AiDecision();
            }

        }

        private void btn_Row4Slot_Click(object sender, EventArgs e)
        {
            playSoundS.Play();
            RowFourClick++;
            int r = 5;
            int c = 3;

            //  find highest empty position
            while (SPBoard.getBoard()[r, c].isFull() == true && r != 0)
            {
                r--;
            }

            if (RowFourClick == 1)
            {
                btn_Row4Space1.BackColor = Color.Red;
            }
            else if (RowFourClick == 2)
            {
                btn_Row4Space2.BackColor = Color.Red;
            }
            else if (RowFourClick == 3)
            {
                btn_Row4Space3.BackColor = Color.Red;
            }
            else if (RowFourClick == 4)
            {
                btn_Row4Space4.BackColor = Color.Red;
            }
            else if (RowFourClick == 5)
            {
                btn_Row4Space5.BackColor = Color.Red;
            }
            else if (RowFourClick == 6)
            {
                btn_Row4Space6.BackColor = Color.Red;
                btn_Row4Slot.Enabled = false;
            }
            SPBoard.getBoard()[r, c].placeDisc("Red");

            if (SPBoard.checkWinner(r, c))
            {
                EndGame(true);
            }
            else
            {
                AiDecision();
            }
        }

        private void btn_Row5Slot_Click(object sender, EventArgs e)
        {
            playSoundS.Play();
            RowFiveClick++;
            int r = 5;
            int c = 4;

            //  find highest empty position
            while (SPBoard.getBoard()[r, c].isFull() == true && r != 0)
            {
                r--;
            }

            if (RowFiveClick == 1)
            {
                btn_Row5Space1.BackColor = Color.Red;
            }
            else if (RowFiveClick == 2)
            {
                btn_Row5Space2.BackColor = Color.Red;
            }
            else if (RowFiveClick == 3)
            {
                btn_Row5Space3.BackColor = Color.Red;
            }
            else if (RowFiveClick == 4)
            {
                btn_Row5Space4.BackColor = Color.Red;
            }
            else if (RowFiveClick == 5)
            {
                btn_Row5Space5.BackColor = Color.Red;
            }
            else if (RowFiveClick == 6)
            {
                btn_Row5Space6.BackColor = Color.Red;
                btn_Row5Slot.Enabled = false;
            }
            SPBoard.getBoard()[r, c].placeDisc("Red");

            if (SPBoard.checkWinner(r, c))
            {
                EndGame(true);
            }
            else
            {
                AiDecision();
            }
        }

        private void btn_Row6Slot_Click(object sender, EventArgs e)
        {
            playSoundS.Play();
            RowSixClick++;
            int r = 5;
            int c = 5;

            //  find highest empty position
            while (SPBoard.getBoard()[r, c].isFull() == true && r != 0)
            {
                r--;
            }

            if (RowSixClick == 1)
            {
                btn_Row6Space1.BackColor = Color.Red;
            }
            else if (RowSixClick == 2)
            {
                btn_Row6Space2.BackColor = Color.Red;
            }
            else if (RowSixClick == 3)
            {
                btn_Row6Space3.BackColor = Color.Red;
            }
            else if (RowSixClick == 4)
            {
                btn_Row6Space4.BackColor = Color.Red;
            }
            else if (RowSixClick == 5)
            {
                btn_Row6Space5.BackColor = Color.Red;
            }
            else if (RowSixClick == 6)
            {
                btn_Row6Space6.BackColor = Color.Red;
                btn_Row6Slot.Enabled = false;
            }

            SPBoard.getBoard()[r, c].placeDisc("Red");

            if (SPBoard.checkWinner(r, c))
            {
                EndGame(true);
            }
            else
            {
                AiDecision();
            }
        }

        private void btn_Row7Slot_Click(object sender, EventArgs e)
        {
            playSoundS.Play();
            RowSevenClick++;
            int r = 5;
            int c = 6;

            //  find highest empty position
            while (SPBoard.getBoard()[r, c].isFull() == true && r != 0)
            {
                r--;
            }

            if (RowSevenClick == 1)
            {
                btn_Row7Space1.BackColor = Color.Red;
            }
            else if (RowSevenClick == 2)
            {
                btn_Row7Space2.BackColor = Color.Red;
            }
            else if (RowSevenClick == 3)
            {
                btn_Row7Space3.BackColor = Color.Red;
            }
            else if (RowSevenClick == 4)
            {
                btn_Row7Space4.BackColor = Color.Red;
            }
            else if (RowSevenClick == 5)
            {
                btn_Row7Space5.BackColor = Color.Red;
            }
            else if (RowSevenClick == 6)
            {
                btn_Row7Space6.BackColor = Color.Red;
                btn_Row7Slot.Enabled = false;
            }
            SPBoard.getBoard()[r, c].placeDisc("Red");

            if (SPBoard.checkWinner(r, c))
            {
                EndGame(true);
            }
            else
            {
                AiDecision();
            }
        }

        //  ==================================================================
        //  SINGLE PLAYER AI MAIN FUNCTION

        private void AiDecision()
        {

            //Board board = new Board();
            Cell[,] board = new Cell[6, 7];
            int[,] PriorityArray = new int[6, 7];
            int[] AiOptions = new int[7];
            int columnPlacement = 0;
            int choice = 0;


            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    //  update board
                    board[r, c] = SPBoard.getCell(r, c);
                    //  preset up priorityArray
                    PriorityArray[r, c] = 0;

                }
            }

            //  fill out prioirty array
            PriorityArray = CheckForPlayerWin(board, PriorityArray);

            //  provide the ai with litmited options for best results
            for (int r = 5; r >= 0; r--)
            {
                for (int c = 0; c < 7; c++)
                {

                    if (PriorityArray[r, c] != 0)
                    {
                        if (AiOptions[c] == 0)
                        {
                            AiOptions[c] = PriorityArray[r, c];
                        }
                    }

                }
            }


            for (int c = 0; c < 7; c++)
            {

                if (AiOptions[c] > choice)
                {
                    choice = AiOptions[c];
                    columnPlacement = c;
                }

            }

            for (int c = 0; c < 7; c++)
            {
                Console.WriteLine(AiOptions[c]);
            }
            Console.WriteLine("It chose C = " + columnPlacement);
            AiPlacesPiece(columnPlacement);
        }

  
        private int[,] CheckForPlayerWin(Cell[,] board, int[,] danger)
        {

            for (int x = 5; x >= 0; x--)
            {
                for (int y = 0; y < 7; y++)
                {
                   
                    //  ======================================================================
                    int i = 0;
                    int j = 0;
                    string colorLocked = "";
                    //Check right from most recently placed disc

                    for (int c = y; j < 4; c++, j++)
                    {
                        if (c < 7)
                        {

                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[x, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                                if (colorLocked == "" && board[x, c].getCellColor() != "Grey")
                                {
                                    colorLocked = board[x, c].getCellColor();
                                    i++;
                                }

                            }

                        }
                    }

                    //Check left from most recently placed disc
                    j = 0;

                    for (int c = y; j < 4; c--, j++)
                    {
                        if (c >= 0)
                        {
                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[x, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                            }

                        }
                    }


                    
                    if (danger[x, y] >= 0 || i >= 3)
                    {
                        if (i > danger[x, y])
                        {
                            danger[x, y] = i;
                        }
                    }

                    if (i >= 3)
                    {
                        //  below the [4] must be [-4]
                        danger[x, y] = i;

                        //  CONVERT ALL TO THIS
                        //  but with safety features
                        if (x < 5 && danger[x + 1, y] != 3 && danger[x + 1, y] != 0)
                        {
                            danger[x + 1, y] = -3;
                        }
                    }
                    //  ======================================================================
                    i = 0;
                    j = 0;
                    colorLocked = "";

                    //Check up from most recently placed disc

                    for (int r = x; j < 4; r--, j++)
                    {
                        if (r >= 0)
                        {


                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[r, y].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                                if (colorLocked == "" && board[r, y].getCellColor() != "Grey")
                                {
                                    colorLocked = board[r, y].getCellColor();
                                    i++;
                                }

                            }

                        }
                    }



                    //Check down from most recently placed disc
                    j = 0;

                    for (int r = x; j < 4; r++, j++)
                    {
                        if (r < 6)
                        {

                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[r, y].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                            }

                        }
                    }

                    if (danger[x, y] >= 0 || i >= 3)
                    {
                        if (i > danger[x, y])
                        {
                            danger[x, y] = i;
                        }
                    }

                    //  ======================================================================

                    //DIAGONALS
                    //Check up-right from most recently placed disc
                    i = 0;
                    j = 0;
                    colorLocked = "";

                    for (int r = x, c = y; j < 4; r--, c++, j++)
                    {
                        if (r >= 0 && c < 7)
                        {

                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[r, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                                if (colorLocked == "" && board[r, c].getCellColor() != "Grey")
                                {
                                    colorLocked = board[r, c].getCellColor();
                                    i++;
                                }

                            }

                        }
                    }



                    //Check down-left from most recently placed disc
                    j = 0;

                    for (int r = x, c = y; j < 4; r++, c--, j++)
                    {
                        if (r < 6 && c >= 0)
                        {

                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[r, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                            }

                        }
                    }

                    if (danger[x, y] >= 0 || i >= 3)
                    {
                        if (i > danger[x, y])
                        {
                            danger[x, y] = i;
                        }
                    }

                    if (i >= 3)
                    {
                        //  below the [4] must be [-4]
                        danger[x, y] = i;

                        //  CONVERT ALL TO THIS
                        //  but with safety features
                        if (x < 5 && danger[x + 1, y] != 3 && danger[x + 1, y] != 0)
                        {
                            danger[x + 1, y] = -3;
                        }
                    }
                    //  ======================================================================

                    //Check up-left from most recently placed disc
                    i = 0;
                    j = 0;
                    colorLocked = "";

                    for (int r = x, c = y; j < 4; r--, c--, j++)
                    {
                        if (r >= 0 && c >= 0)
                        {


                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[r, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                                if (colorLocked == "" && board[r, c].getCellColor() != "Grey")
                                {
                                    colorLocked = board[r, c].getCellColor();
                                    i++;
                                }

                            }

                        }
                    }



                    //Check down-right from most recently placed disc
                    j = 0;

                    for (int r = x, c = y; j < 4; r++, c++, j++)
                    {
                        if (r < 6 && c < 7)
                        {


                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[r, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                            }

                        }
                    }

                    if (danger[x, y] >= 0 || i >= 3)
                    {
                        if (i > danger[x, y])
                        {
                            danger[x, y] = i;
                        }
                    }

                    if (i >= 3)
                    {
                        //  below the [4] must be [-4]
                        danger[x, y] = i;

                        //  CONVERT ALL TO THIS
                        //  but with safety features
                        if (x < 5 && danger[x + 1, y] != 3 && danger[x + 1, y] != 0)
                        {
                            danger[x + 1, y] = -3;
                        }
                    }
                    i = 0;
                    j = 0;
                    colorLocked = "";

                    //Check Left from most recently placed disc

                    for (int c = y; j < 4; c--, j++)
                    {
                        if (c >= 0)
                        {

                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[x, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                                if (colorLocked == "" && board[x, c].getCellColor() != "Grey")
                                {
                                    colorLocked = board[x, c].getCellColor();
                                    i++;
                                }

                            }

                        }
                    }


                    //Check Right from most recently placed disc
                    j = 0;

                    for (int c = y; j < 4; c++, j++)
                    {
                        if (c < 7)
                        {

                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[x, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                            }

                        }
                    }

                    if (danger[x, y] >= 0)
                    {
                        if (i > danger[x, y])
                        {
                            danger[x, y] = i;
                        }
                    }

                    if (i >= 3)
                    {
                        //  below the [4] must be [-4]
                        danger[x, y] = i;

                        //  CONVERT ALL TO THIS
                        //  but with safety features
                        if (x < 5 && danger[x + 1, y] != 3 && danger[x + 1, y] != 0)
                        {
                            danger[x + 1, y] = -3;
                        }
                    }

                    i = 0;
                    j = 0;
                    colorLocked = "";

                    //Check Down from most recently placed disc
                    for (int r = x; j < 4; r++, j++)
                    {
                        if (r < 6)
                        {

                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[r, y].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                                if (colorLocked == "" && board[r, y].getCellColor() != "Grey")
                                {
                                    colorLocked = board[r, y].getCellColor();
                                    i++;
                                }

                            }

                        }
                    }



                    //Check up from most recently placed disc
                    j = 0;

                    for (int r = x; j < 4; r--, j++)
                    {
                        if (r >= 0)
                        {

                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[r, y].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                                //if (colorLocked == "" && board[r, y].getCellColor() != "Grey")
                                //{
                                //    colorLocked = board[r, y].getCellColor();
                                //}

                            }

                        }
                    }

                    if (danger[x, y] >= 0 || i >= 3)
                    {
                        if (i > danger[x, y])
                        {
                            danger[x, y] = i;
                        }
                    }


                    //  ======================================================================

                    //DIAGONALS
                    //Check up-Left from most recently placed disc
                    i = 0;
                    j = 0;
                    colorLocked = "";

                    for (int r = x, c = y; j < 4; r++, c--, j++)
                    {
                        if (r < 6 && c >= 0)
                        {

                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[r, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                                if (colorLocked == "" && board[r, c].getCellColor() != "Grey")
                                {
                                    colorLocked = board[r, c].getCellColor();
                                    i++;
                                }

                            }

                        }
                    }



                    //Check down-Right from most recently placed disc
                    j = 0;

                    for (int r = x, c = y; j < 4; r--, c++, j++)
                    {
                        if (r >= 0 && c < 7)
                        {


                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[r, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }


                            }

                        }
                    }

                    if (danger[x, y] >= 0 || i >= 3)
                    {
                        if (i > danger[x, y])
                        {
                            danger[x, y] = i;
                        }
                    }

                    if (i >= 3)
                    {
                        //  below the [4] must be [-4]
                        danger[x, y] = i;

                        //  CONVERT ALL TO THIS
                        //  but with safety features
                        if (x < 5 && danger[x + 1, y] != 3 && danger[x + 1, y] != 0)
                        {
                            danger[x + 1, y] = -3;
                        }
                    }

                    //  ======================================================================

                    //Check Down-left from most recently placed disc
                    i = 0;
                    j = 0;
                    colorLocked = "";

                    for (int r = x, c = y; j < 4; r++, c++, j++)
                    {
                        if (r < 6 && c < 7)
                        {

                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[r, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                                if (colorLocked == "" && board[r, c].getCellColor() != "Grey")
                                {
                                    colorLocked = board[r, c].getCellColor();
                                    i++;
                                }

                            }

                        }
                    }



                    //Check Up-right from most recently placed disc
                    j = 0;

                    for (int r = x, c = y; j < 4; r--, c--, j++)
                    {
                        if (r >= 0 && c >= 0)
                        {

                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[r, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                            }

                        }
                    }

                    if (danger[x, y] >= 0 || i >= 3)
                    {
                        if (i > danger[x, y])
                        {
                            danger[x, y] = i;
                        }
                    }

                    if (i >= 3)
                    {
                        //  below the [4] must be [-4]
                        danger[x, y] = i;



                        //  CONVERT ALL TO THIS
                        //  but with safety features
                        if (x < 5 && danger[x + 1, y] != 3 && danger[x + 1, y] != 0)
                        {
                            danger[x + 1, y] = -3;
                        }
                    }

                }
            }


            return danger;

        }

        private void AiPlacesPiece(int c)
        {
             
            //  these are just all the cases as in btn_row#Slot_Click
            //  but for the Ai to place

            if (c == 0)
            {
                RowOneClick++;
                int r = 5;

                //  find highest empty position
                while (SPBoard.getBoard()[r, c].isFull() == true && r != 0)
                {
                    r--;
                }

                //  Display change
                if (RowOneClick == 1)
                {
                    btn_Row1Space1.BackColor = Color.Yellow;
                }
                else if (RowOneClick == 2)
                {
                    btn_Row1Space2.BackColor = Color.Yellow;
                }
                else if (RowOneClick == 3)
                {
                    btn_Row1Space3.BackColor = Color.Yellow;
                }
                else if (RowOneClick == 4)
                {
                    btn_Row1Space4.BackColor = Color.Yellow;
                }
                else if (RowOneClick == 5)
                {
                    btn_Row1Space5.BackColor = Color.Yellow;
                }
                else if (RowOneClick == 6)
                {
                    btn_Row1Space6.BackColor = Color.Yellow;
                    btn_Row1Slot.Enabled = false;
                }
                SPBoard.getBoard()[r, c].placeDisc("Yellow");
                if (SPBoard.checkWinner(r, c))
                {
                    EndGame(false);
                }
            }
            else if (c == 1)
            {
                RowTwoClick++;
                int r = 5;


                //  find highest empty position
                while (SPBoard.getBoard()[r, c].isFull() == true && r != 0)
                {
                    r--;
                }

                if (RowTwoClick == 1)
                {
                    btn_Row2Space1.BackColor = Color.Yellow;
                }
                else if (RowTwoClick == 2)
                {
                    btn_Row2Space2.BackColor = Color.Yellow;
                }
                else if (RowTwoClick == 3)
                {
                    btn_Row2Space3.BackColor = Color.Yellow;
                }
                else if (RowTwoClick == 4)
                {
                    btn_Row2Space4.BackColor = Color.Yellow;
                }
                else if (RowTwoClick == 5)
                {
                    btn_Row2Space5.BackColor = Color.Yellow;
                }
                else if (RowTwoClick == 6)
                {
                    btn_Row2Space6.BackColor = Color.Yellow;
                    btn_Row2Slot.Enabled = false;
                }
                SPBoard.getBoard()[r, c].placeDisc("Yellow");
                if (SPBoard.checkWinner(r, c))
                {
                    EndGame(false);
                }
            }
            else if (c == 2)
            {
                RowThreeClick++;
                int r = 5;

                //  find highest empty position
                while (SPBoard.getBoard()[r, c].isFull() == true && r != 0)
                {
                    r--;
                }

                if (RowThreeClick == 1)
                {
                    btn_Row3Space1.BackColor = Color.Yellow;
                }
                else if (RowThreeClick == 2)
                {
                    btn_Row3Space2.BackColor = Color.Yellow;
                }
                else if (RowThreeClick == 3)
                {
                    btn_Row3Space3.BackColor = Color.Yellow;
                }
                else if (RowThreeClick == 4)
                {
                    btn_Row3Space4.BackColor = Color.Yellow;
                }
                else if (RowThreeClick == 5)
                {
                    btn_Row3Space5.BackColor = Color.Yellow;
                }
                else if (RowThreeClick == 6)
                {
                    btn_Row3Space6.BackColor = Color.Yellow;
                    btn_Row3Slot.Enabled = false;
                }
                SPBoard.getBoard()[r, c].placeDisc("Yellow");
                if (SPBoard.checkWinner(r, c))
                {
                    EndGame(false);
                }
            }
            else if (c == 3)
            {
                RowFourClick++;
                int r = 5;

                //  find highest empty position
                while (SPBoard.getBoard()[r, c].isFull() == true && r != 0)
                {
                    r--;
                }

                if (RowFourClick == 1)
                {
                    btn_Row4Space1.BackColor = Color.Yellow;
                }
                else if (RowFourClick == 2)
                {
                    btn_Row4Space2.BackColor = Color.Yellow;
                }
                else if (RowFourClick == 3)
                {
                    btn_Row4Space3.BackColor = Color.Yellow;
                }
                else if (RowFourClick == 4)
                {
                    btn_Row4Space4.BackColor = Color.Yellow;
                }
                else if (RowFourClick == 5)
                {
                    btn_Row4Space5.BackColor = Color.Yellow;
                }
                else if (RowFourClick == 6)
                {
                    btn_Row4Space6.BackColor = Color.Yellow;
                    btn_Row4Slot.Enabled = false;
                }
                SPBoard.getBoard()[r, c].placeDisc("Yellow");
                if (SPBoard.checkWinner(r, c))
                {
                    EndGame(false);
                }
            }
            else if (c == 4)
            {
                RowFiveClick++;
                int r = 5;

                //  find highest empty position
                while (SPBoard.getBoard()[r, c].isFull() == true && r != 0)
                {
                    r--;
                }

                if (RowFiveClick == 1)
                {
                    btn_Row5Space1.BackColor = Color.Yellow;
                }
                else if (RowFiveClick == 2)
                {
                    btn_Row5Space2.BackColor = Color.Yellow;
                }
                else if (RowFiveClick == 3)
                {
                    btn_Row5Space3.BackColor = Color.Yellow;
                }
                else if (RowFiveClick == 4)
                {
                    btn_Row5Space4.BackColor = Color.Yellow;
                }
                else if (RowFiveClick == 5)
                {
                    btn_Row5Space5.BackColor = Color.Yellow;
                }
                else if (RowFiveClick == 6)
                {
                    btn_Row5Space6.BackColor = Color.Yellow;
                    btn_Row5Slot.Enabled = false;
                }
                SPBoard.getBoard()[r, c].placeDisc("Yellow");
                if (SPBoard.checkWinner(r, c))
                {
                    EndGame(false);
                }
            }
            else if (c == 5)
            {
                RowSixClick++;
                int r = 5;

                //  find highest empty position
                while (SPBoard.getBoard()[r, c].isFull() == true && r != 0)
                {
                    r--;
                }

                if (RowSixClick == 1)
                {
                    btn_Row6Space1.BackColor = Color.Yellow;
                }
                else if (RowSixClick == 2)
                {
                    btn_Row6Space2.BackColor = Color.Yellow;
                }
                else if (RowSixClick == 3)
                {
                    btn_Row6Space3.BackColor = Color.Yellow;
                }
                else if (RowSixClick == 4)
                {
                    btn_Row6Space4.BackColor = Color.Yellow;
                }
                else if (RowSixClick == 5)
                {
                    btn_Row6Space5.BackColor = Color.Yellow;
                }
                else if (RowSixClick == 6)
                {
                    btn_Row6Space6.BackColor = Color.Yellow;
                    btn_Row6Slot.Enabled = false;
                }
                SPBoard.getBoard()[r, c].placeDisc("Yellow");
                if (SPBoard.checkWinner(r, c))
                {
                    EndGame(false);
                }
            }
            else if (c == 6)
            {
                RowSevenClick++;
                int r = 5;

                //  find highest empty position
                while (SPBoard.getBoard()[r, c].isFull() == true && r != 0)
                {
                    r--;
                }

                if (RowSevenClick == 1)
                {
                    btn_Row7Space1.BackColor = Color.Yellow;
                }
                else if (RowSevenClick == 2)
                {
                    btn_Row7Space2.BackColor = Color.Yellow;
                }
                else if (RowSevenClick == 3)
                {
                    btn_Row7Space3.BackColor = Color.Yellow;
                }
                else if (RowSevenClick == 4)
                {
                    btn_Row7Space4.BackColor = Color.Yellow;
                }
                else if (RowSevenClick == 5)
                {
                    btn_Row7Space5.BackColor = Color.Yellow;
                }
                else if (RowSevenClick == 6)
                {
                    btn_Row7Space6.BackColor = Color.Yellow;
                    btn_Row7Slot.Enabled = false;
                }
                SPBoard.getBoard()[r, c].placeDisc("Yellow");
                if (SPBoard.checkWinner(r, c))
                {
                    EndGame(false);
                }
            }


        }

        //IF WINNER
        private void EndGame(bool playersTurn)
        {
            // Disable all buttons
            btn_Row1Slot.Enabled = false;
            btn_Row2Slot.Enabled = false;
            btn_Row3Slot.Enabled = false;
            btn_Row4Slot.Enabled = false;
            btn_Row5Slot.Enabled = false;
            btn_Row6Slot.Enabled = false;
            btn_Row7Slot.Enabled = false;

            if (playersTurn && SPBoard.checkTie() == false) // Player wins
            {
                UpdateStats(true, false);
                // Hide this form
                this.Hide();

                // Open the winner form and pass it the necessary arguments
                Winner winnerForm = new Winner(this, MainScreenForm, 0);
                winnerForm.Show();
            }
            else if (SPBoard.checkTie() == false) // AI wins
            {
                UpdateStats(false, true);
                // Hide this form
                this.Hide();

                // Open the winner form and pass it the necessary arguments
                Winner winnerForm = new Winner(this, MainScreenForm, 1);
                winnerForm.Show();
            }
            else if (SPBoard.checkTie()) // Tie
            {
                UpdateStats(false, false);
                // Hide this form
                this.Hide();

                // Open the winner form and pass it the necessary arguments
                Winner winnerForm = new Winner(this, MainScreenForm, 2);
                winnerForm.Show();
            }



        }
        private void UpdateStats(bool playerWon, bool aiWon)
        {
            // Read the current statistics from the text file
            int playerWins = 0;
            int computerWins = 0;
            int ties = 0;
            int totalGames = 0;

            StreamReader reader = new StreamReader("stats.txt");

            playerWins = 0;
            string playerWinsStr = reader.ReadLine();
            if (playerWinsStr != null)
            {
                playerWins = int.Parse(playerWinsStr);
            }

            computerWins = 0;
            string computerWinsStr = reader.ReadLine();
            if (computerWinsStr != null)
            {
                computerWins = int.Parse(computerWinsStr);
            }

            ties = 0;
            string tiesStr = reader.ReadLine();
            if (tiesStr != null)
            {
                ties = int.Parse(tiesStr);
            }

            totalGames = 0;
            string totalGamesStr = reader.ReadLine();
            if (totalGamesStr != null)
            {
                totalGames = int.Parse(totalGamesStr);
            }
            reader.Close();
            // Update the statistics based on the outcome of the game
            if (playerWon)
            {
                playerWins++;
            }
            else if (aiWon)
            {
                computerWins++;
            }
            else
            {
                ties++;
            }

            totalGames++;
            Console.WriteLine(playerWins);
            Console.WriteLine(computerWins);
            Console.WriteLine(ties);
            Console.WriteLine(totalGames);
            // Write the updated statistics back to the text file
            StreamWriter writer = new StreamWriter("stats.txt");

            writer.WriteLine(playerWins);
            writer.WriteLine(computerWins);
            writer.WriteLine(ties);
            writer.WriteLine(totalGames);

            writer.Close();
        }






        //==================================================================
        //VISUAL HOVER FUNCTIONS
        private void btn_Row1Slot_MouseHover(object sender, EventArgs e)
        {
            if (RowOneClick == 0)
            {
                btn_Row1Space1.BackColor = Color.Pink;
            }
            else if (RowOneClick == 1)
            {
                btn_Row1Space2.BackColor = Color.Pink;
            }
            else if (RowOneClick == 2)
            {
                btn_Row1Space3.BackColor = Color.Pink;
            }
            else if (RowOneClick == 3)
            {
                btn_Row1Space4.BackColor = Color.Pink;
            }
            else if (RowOneClick == 4)
            {
                btn_Row1Space5.BackColor = Color.Pink;
            }
            else if (RowOneClick == 5)
            {
                btn_Row1Space6.BackColor = Color.Pink;
            }
        }

        private void btn_Row2Slot_MouseHover(object sender, EventArgs e)
        {
            if (RowTwoClick == 0)
            {
                btn_Row2Space1.BackColor = Color.Pink;
            }
            else if (RowTwoClick == 1)
            {
                btn_Row2Space2.BackColor = Color.Pink;
            }
            else if (RowTwoClick == 2)
            {
                btn_Row2Space3.BackColor = Color.Pink;
            }
            else if (RowTwoClick == 3)
            {
                btn_Row2Space4.BackColor = Color.Pink;
            }
            else if (RowTwoClick == 4)
            {
                btn_Row2Space5.BackColor = Color.Pink;
            }
            else if (RowTwoClick == 5)
            {
                btn_Row2Space6.BackColor = Color.Pink;
            }
        }

        private void btn_Row3Slot_MouseHover(object sender, EventArgs e)
        {
            if (RowThreeClick == 0)
            {
                btn_Row3Space1.BackColor = Color.Pink;
            }
            else if (RowThreeClick == 1)
            {
                btn_Row3Space2.BackColor = Color.Pink;
            }
            else if (RowThreeClick == 2)
            {
                btn_Row3Space3.BackColor = Color.Pink;
            }
            else if (RowThreeClick == 3)
            {
                btn_Row3Space4.BackColor = Color.Pink;
            }
            else if (RowThreeClick == 4)
            {
                btn_Row3Space5.BackColor = Color.Pink;
            }
            else if (RowThreeClick == 5)
            {
                btn_Row3Space6.BackColor = Color.Pink;
            }
        }

        private void btn_Row4Slot_MouseHover(object sender, EventArgs e)
        {
            if (RowFourClick == 0)
            {
                btn_Row4Space1.BackColor = Color.Pink;
            }
            else if (RowFourClick == 1)
            {
                btn_Row4Space2.BackColor = Color.Pink;
            }
            else if (RowFourClick == 2)
            {
                btn_Row4Space3.BackColor = Color.Pink;
            }
            else if (RowFourClick == 3)
            {
                btn_Row4Space4.BackColor = Color.Pink;
            }
            else if (RowFourClick == 4)
            {
                btn_Row4Space5.BackColor = Color.Pink;
            }
            else if (RowFourClick == 5)
            {
                btn_Row4Space6.BackColor = Color.Pink;
            }
        }

        private void btn_Row5Slot_MouseHover(object sender, EventArgs e)
        {
            if (RowFiveClick == 0)
            {
                btn_Row5Space1.BackColor = Color.Pink;
            }
            else if (RowFiveClick == 1)
            {
                btn_Row5Space2.BackColor = Color.Pink;
            }
            else if (RowFiveClick == 2)
            {
                btn_Row5Space3.BackColor = Color.Pink;
            }
            else if (RowFiveClick == 3)
            {
                btn_Row5Space4.BackColor = Color.Pink;
            }
            else if (RowFiveClick == 4)
            {
                btn_Row5Space5.BackColor = Color.Pink;
            }
            else if (RowFiveClick == 5)
            {
                btn_Row5Space6.BackColor = Color.Pink;
            }
        }

        private void btn_Row6Slot_MouseHover(object sender, EventArgs e)
        {
            if (RowSixClick == 0)
            {
                btn_Row6Space1.BackColor = Color.Pink;
            }
            else if (RowSixClick == 1)
            {
                btn_Row6Space2.BackColor = Color.Pink;
            }
            else if (RowSixClick == 2)
            {
                btn_Row6Space3.BackColor = Color.Pink;
            }
            else if (RowSixClick == 3)
            {
                btn_Row6Space4.BackColor = Color.Pink;
            }
            else if (RowSixClick == 4)
            {
                btn_Row6Space5.BackColor = Color.Pink;
            }
            else if (RowSixClick == 5)
            {
                btn_Row6Space6.BackColor = Color.Pink;
            }
        }

        private void btn_Row7Slot_MouseHover(object sender, EventArgs e)
        {
            if (RowSevenClick == 0)
            {
                btn_Row7Space1.BackColor = Color.Pink;
            }
            else if (RowSevenClick == 1)
            {
                btn_Row7Space2.BackColor = Color.Pink;
            }
            else if (RowSevenClick == 2)
            {
                btn_Row7Space3.BackColor = Color.Pink;
            }
            else if (RowSevenClick == 3)
            {
                btn_Row7Space4.BackColor = Color.Pink;
            }
            else if (RowSevenClick == 4)
            {
                btn_Row7Space5.BackColor = Color.Pink;
            }
            else if (RowSevenClick == 5)
            {
                btn_Row7Space6.BackColor = Color.Pink;
            }
        }

        //  ========================================================
        //  VISUAL UN-HOVER FUNCTIONS
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
