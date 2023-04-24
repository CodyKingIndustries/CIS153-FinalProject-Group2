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
            //  this will allow us to return to the main screen form if we need to
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
            //  in order for this to close -> either the game needs to end / or the user must exit
            //  this is just temporary framework
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
            
           

            //  needs to check for column being filled before this function calls
            //  and if column == filled -> change placement number to next highest priority
            AiPlacesPiece(columnPlacement);

            

        }

        //  This searches the current board state, and returns "danger" which is an int[,]
        //  higher number = more pieces in a row
        private int[,] CheckForPlayerWin(Cell[,] board, int[,] danger)
        {
            //  Progress:
            //  
            //  Knows all locations based on their number of pieces in a row
            //  I am working on only letting it place pieces off of available spots


            //  j is a counter
            //  y is columns [c]
            //  x is Rows [r]
            //  This is all copied and modified code from "checkWinner" in Board.cs
            //  so that I can use the same algorith to instead find 2 & 3 in a row, Not 4 [already game over]
            //for (int x = 0; x < 6; x++)
            for (int x = 5; x >= 0; x--)
            {
                for (int y = 0; y < 7; y++)
                {
                    //Hardest part is to not go out of bounds of the array

                    //  ======================================================================
                    int i = 0;
                    int j = 0;
                    string colorLocked = "";
                    //Check right from most recently placed disc

                    for (int c = y; j < 4; c++, j++)
                    {
                        if (c < 7)
                        {
                            //if (board[x, c].getCellColor() == board[x, y].getCellColor())
                            //{
                            //    i++;
                            //}
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
                            //if (board[x, y].getCellColor() != "Grey")
                            //{
                            //    if (board[x, c].getCellColor() == board[x, y].getCellColor())
                            //    {
                            //        i++;
                            //    }
                            //}

                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[x, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                                //  shouldnt need this becuase it is going in a pair
                                //if (colorLocked == "" && board[x, c].getCellColor() != "Grey")
                                //{
                                //    colorLocked = board[x, c].getCellColor();
                                //}

                            }

                        }
                    }


                    //  Pobalby only need one check not 2
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

                    //if (danger[x, y] <= -3)
                    //{
                    //    Console.WriteLine("Left and Right: " + x + "," + y + i + " -> " + danger[x, y]);
                    //}

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
                            //if (board[x, y].getCellColor() != "Grey")
                            //{
                            //    if (board[r, y].getCellColor() == board[x, y].getCellColor())
                            //    {
                            //        i++;
                            //    }
                            //}

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

                    //if (i >= 3)
                    //{
                    //    //  below the [4] must be [-4]
                    //    danger[x, y] = i;

                    //    //  CONVERT ALL TO THIS
                    //    //  but with safety features
                    //    if (x < 5)
                    //    {
                    //        danger[x + 1, y] = -i;
                    //    }
                    //}

                    //if (danger[x, y] <= -3)
                    //{
                    //    Console.WriteLine("Up + Down: " + x + "," + y + i + " -> " + danger[x, y]);
                    //}
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
                            //if (board[x, y].getCellColor() != "Grey")
                            //{
                            //    if (board[x, c].getCellColor() == board[x, y].getCellColor())
                            //    {
                            //        i++;
                            //    }
                            //}

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
                            //if (board[x, y].getCellColor() != "Grey")
                            //{
                            //    if (board[x, c].getCellColor() == board[x, y].getCellColor())
                            //    {
                            //        i++;
                            //    }
                            //}

                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[r, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                                //if (colorLocked == "" && board[r, c].getCellColor() != "Grey")
                                //{
                                //    colorLocked = board[r, c].getCellColor();
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

                    //if (danger[x, y] <= -3)
                    //{
                    //    Console.WriteLine("DLeft and URight: " + x + "," + y + i + " -> " + danger[x, y]);
                    //}

                    //  ======================================================================

                    //Check up-left from most recently placed disc
                    i = 0;
                    j = 0;
                    colorLocked = "";

                    for (int r = x, c = y; j < 4; r--, c--, j++)
                    {
                        if (r >= 0 && c >= 0)
                        {
                            //if (board[x, y].getCellColor() != "Grey")
                            //{
                            //    if (board[x, c].getCellColor() == board[x, y].getCellColor())
                            //    {
                            //        i++;
                            //    }
                            //}

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
                            //if (board[x, y].getCellColor() != "Grey")
                            //{
                            //    if (board[x, c].getCellColor() == board[x, y].getCellColor())
                            //    {
                            //        i++;
                            //    }
                            //}

                            if (board[x, y].getCellColor() == "Grey")
                            {

                                if (board[r, c].getCellColor() == colorLocked)
                                {
                                    i++;
                                }

                                //if (colorLocked == "" && board[r, c].getCellColor() != "Grey")
                                //{
                                //    colorLocked = board[r, c].getCellColor();
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

                    //if (danger[x, y] <= -3)
                    //{
                    //    Console.WriteLine("ULeft and DRight: " + x + "," + y + i + " -> " + danger[x, y]);
                    //}

                    //  ======================================================================
                    //  Repeat but in reverse
                    //  
                    //  ======================================================================
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

                                //if (colorLocked == "" && board[x, c].getCellColor() != "Grey")
                                //{
                                //    colorLocked = board[x, c].getCellColor();
                                //    i++;
                                //}

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

                    //if (danger[x, y] <= -3)
                    //{
                    //    Console.WriteLine("I Left and Right: " + x + "," + y + i + " -> " + danger[x, y]);
                    //}

                    //  ======================================================================
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

                    //if (i >= 3)
                    //{
                    //    //  below the [4] must be [-4]
                    //    danger[x, y] = i;

                    //    //  CONVERT ALL TO THIS
                    //    //  but with safety features
                    //    if (x < 5)
                    //    {
                    //        danger[x + 1, y] = -i;
                    //    }
                    //}

                    //if (danger[x, y] <= -3)
                    //{
                    //    Console.WriteLine("I Up + Down: " + x + "," + y + i + " -> " + danger[x, y]);
                    //}

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

                                //if (colorLocked == "" && board[r, c].getCellColor() != "Grey")
                                //{
                                //    colorLocked = board[r, c].getCellColor();
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

                    //if (danger[x, y] <= -3)
                    //{
                    //    Console.WriteLine("I ULeft and DRight: " + x + "," + y + i + " -> " + danger[x, y]);

                    //}
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

                                //if (colorLocked == "" && board[r, c].getCellColor() != "Grey")
                                //{
                                //    colorLocked = board[r, c].getCellColor();
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

                    //if (danger[x, y] <= -3)
                    //{
                    //    Console.WriteLine("I DLeft and URight: " + x + "," + y + i + " -> " + danger[x, y]);
                    //}

                    //  ======================================================================

                }
            }


            return danger;

        }

        private void AiPlacesPiece(int c)
        {
           // playSoundS.Play();
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
            //Technically not needed anymore since it just loads a whole new form and closes this one
            //But not too sure yet since reviewing the board reopens it and we wouldn't want the user to be able to click
            btn_Row1Slot.Enabled = false;
            btn_Row2Slot.Enabled = false;
            btn_Row3Slot.Enabled = false;
            btn_Row4Slot.Enabled = false;
            btn_Row5Slot.Enabled = false;
            btn_Row6Slot.Enabled = false;
            btn_Row7Slot.Enabled = false;
            if (playersTurn && SPBoard.checkTie() == false)
            {
                Console.WriteLine("True Indeed");

                //Make winner form given this form (for a play again option), main menu form
                //(for option to go back to menu), and a boolean stating whether the player won or ai won
                Winner WinnerForm = new Winner(this, MainScreenForm, 0);
                //Close this form
                this.Hide();
                //Load Winner form
                WinnerForm.Show();
            }
            else if (SPBoard.checkTie() == true)
            {
                Winner WinnerForm = new Winner(this, MainScreenForm, 2);
                //Close this form
                this.Hide();
                //Load Winner form
                WinnerForm.Show();
            }
            else
            {
                Console.WriteLine("False Indeed");
                //Make winner form given this form (for a play again option), main menu form
                //(for option to go back to menu), and a number indicating who won (0 for player, 1 for ai, 2 for tie)
                Winner WinnerForm = new Winner(this, MainScreenForm, 1);
                //Close this form
                this.Hide();
                //Load Winner form
                WinnerForm.Show();
            }
            //Will need another option for a tie (might need this function to accept
            //something other than a bool so we can have 3 options instead of 2
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
