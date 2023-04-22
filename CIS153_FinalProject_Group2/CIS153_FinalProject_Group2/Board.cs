using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject_Group2
{
    internal class Board
    {
        
        private const int numRows = 6; // number of rows in the game board
        private const int numCols = 7; // number of columns in the game board
        private Cell[,] board = new Cell[numRows, numCols]; // 2D array of Cells representing the game board
        private bool occupied;
        private bool winner;

        //  Currently UNUSED
        // Constructor to initialize the board with empty cells
        //  ====================================================
        //  The rows and colums never change....  Thus no need to construct the- 
        //  -board using a new set of given rows/colums every time. 
        public Board(int numRows, int numCols)
        {
            board = new Cell[numRows, numCols];

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    board[row, col] = new Cell();
                }
            }
        }
        
        //  This overloaded constructor established the whole board with value "Grey" instead of null
        public Board()
        {
            //Cell CreateCell = new Cell();
            
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    //  all cells are assigned the color of "Grey" becuase when calling a funciton to get the value
                    //  without a given color already established, it breaks.
                    //  thus all non used cells can be intpreted as "grey" == "null" == "un-used"
                    Cell newCell = new Cell(row, col, "Grey");
                    board[row, col] = newCell;
                }
            }

        }


        public Cell getCell(int r, int c)
        {
            return board[r, c];
        }
        public void setCell(int r, int c, Cell C)
        {
            board[r, c] = C;
        }
        //===========

        public int getNumRows()
        {
            return numRows;
        }
       
        public int getNumCols()
        {
            return numCols;
        }
        
        //OFFICIAL CHECK FOR WINNER (at least for two player form) PLEASE DO NOT REMOVE (can probably use the same code for single player form)
        public bool checkWinner(int x, int y)
        {
            //Hardest part is to not go out of bounds of the array
            winner = false;
            bool stopOnGrey = false;
            int i = 0;
            int j = 0;

            //Check right from most recently placed disc
            for (int c = y; j < 4; c++, j++)
            {
                if (c < numCols)
                {
                    if (board[x, c].getCellColor() == board[x, y].getCellColor() && stopOnGrey == false)
                    {
                        i++;
                    }
                    if (board[x, c].getCellColor() == "Grey")
                    {
                        stopOnGrey = true;
                    }
                }
            }
            Console.WriteLine("Checked Right");
            if (i > 4)
            {
                winner = true;
                return winner;
            }

            //Check left from most recently placed disc
            i = 0;
            j = 0;
            stopOnGrey = false;
            for (int c = y; j < 4; c--, j++)
            {
                if (c >= 0)
                {
                    if (board[x, c].getCellColor() == board[x, y].getCellColor() && stopOnGrey == false)
                    {
                        i++;
                    }
                    if (board[x, c].getCellColor() == "Grey")
                    {
                        stopOnGrey = true;
                    }
                }
            }
            Console.WriteLine("Checked Left");
            if (i > 4)
            {
                winner = true;
                return winner;
            }

            //Check up from most recently placed disc
            i = 0;
            j = 0;
            stopOnGrey = false;
            for (int r = x; j < 4; r--, j++)
            {
                if (r >= 0)
                {
                    if (board[r, y].getCellColor() == board[x, y].getCellColor() && stopOnGrey == false)
                    {
                        i++;
                    }
                    if (board[r, y].getCellColor() == "Grey")
                    {
                        stopOnGrey = true;
                    }
                }
            }
            Console.WriteLine("Checked Up");
            if (i > 4)
            {
                winner = true;
                return winner;
            }

            //Check down from most recently placed disc
            i = 0;
            j = 0;
            stopOnGrey = false;
            for (int r = x; j < 4; r++, j++)
            {
                if (r < numRows)
                {
                    if (board[r, y].getCellColor() == board[x, y].getCellColor() && stopOnGrey == false)
                    {
                        i++;
                    }
                    if (board[r, y].getCellColor() == "Grey")
                    {
                        stopOnGrey = true;
                    }
                }
            }
            Console.WriteLine("Checked Down");
            if (i > 4)
            {
                winner = true;
                return winner;
            }

            //DIAGONALS
            //Check up-right from most recently placed disc
            i = 0;
            j = 0;
            stopOnGrey = false;
            for (int r = x, c = y; j < 4; r--, c++, j++)
            {
                if (r >= 0 && c < numCols)
                {
                    if (board[r, c].getCellColor() == board[x, y].getCellColor() && stopOnGrey == false)
                    {
                        i++;
                    }
                    if (board[r, c].getCellColor() == "Grey")
                    {
                        stopOnGrey = true;
                    }
                }
            }
            Console.WriteLine("Checked UpRight");
            if (i > 4)
            {
                winner = true;
                return winner;
            }

            //Check down-left from most recently placed disc
            i = 0;
            j = 0;
            stopOnGrey = false;
            for (int r = x, c = y; j < 4; r++, c--, j++)
            {
                if (r < numRows && c >= 0)
                {
                    if (board[r, c].getCellColor() == board[x, y].getCellColor() && stopOnGrey == false)
                    {
                        i++;
                    }
                    if (board[r, c].getCellColor() == "Grey")
                    {
                        stopOnGrey = true;
                    }
                }
            }
            Console.WriteLine("Checked DownLeft");
            if (i > 4)
            {
                winner = true;
                return winner;
            }

            //Check up-left from most recently placed disc
            i = 0;
            j = 0;
            stopOnGrey = false;
            for (int r = x, c = y; j < 4; r--, c--, j++)
            {
                if (r >= 0 && c >= 0)
                {
                    if (board[r, c].getCellColor() == board[x, y].getCellColor() && stopOnGrey == false)
                    {
                        i++;
                    }
                    if (board[r, c].getCellColor() == "Grey")
                    {
                        stopOnGrey = true;
                    }
                }
            }
            Console.WriteLine("Checked UpLeft");
            if (i > 4)
            {
                winner = true;
                return winner;
            }

            //Check down-right from most recently placed disc
            i = 0;
            j = 0;
            stopOnGrey = false;
            for (int r = x, c = y; j < 4; r++, c++, j++)
            {
                if (r < numRows && c < numCols)
                {
                    if (board[r, c].getCellColor() == board[x, y].getCellColor() && stopOnGrey == false)
                    {
                        i++;
                    }
                    if (board[r, c].getCellColor() == "Grey")
                    {
                        stopOnGrey = true;
                    }
                }
            }
            Console.WriteLine("Checked DownRight");
            if (i > 4)
            {
                winner = true;
                return winner;
            }
            

            Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine);
            return winner;
        }


        //  Will place a disk at given colum, with color representing players turn
        public void PlaceDisc(int col, string c)
        {
            int row = GetNextEmptyRow(col);
            if (row != -1)
            {
                board[row, col].setCellColor(c);
            }
        }
        
        //  ====================================================================================

        public int GetNextEmptyRow(int col)
        {
            for (int row = numRows - 1; row >= 0; row--)
            {                                                 //  Changed due to erorr with calling a null disk, [null == grey] now.
                if (board[row, col].getCellColor() == "Grey") //(board[row, col].GetDisc() == null ) || 
                {
                    return row;
                }
            }
            return -1;
        }

        // Function to check if a column is full
        public bool IsColumnFull(int col)
        {
            return board[0, col].GetDisc() != null;
        }

        // Function to check if the board is full
        public bool IsBoardFull()
        {
            for (int col = 0; col < numCols; col++)
            {
                if (!IsColumnFull(col))
                {
                    return false;
                }
            }
            return true;
        }

        // Function to check if there is a winning configuration of discs on the board
        public bool HasWinner()
        {
            // Check horizontal
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols - 3; col++)
                {
                    if (board[row, col].GetDisc() != null &&
                        board[row, col].GetDisc() == board[row, col + 1].GetDisc() &&
                        board[row, col].GetDisc() == board[row, col + 2].GetDisc() &&
                        board[row, col].GetDisc() == board[row, col + 3].GetDisc())
                    {
                        return true;
                    }
                }
            }

            // Check vertical
            for (int row = 0; row < numRows - 3; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (board[row, col].GetDisc() != null &&
                        board[row, col].GetDisc() == board[row + 1, col].GetDisc() &&
                        board[row, col].GetDisc() == board[row + 2, col].GetDisc() &&
                        board[row, col].GetDisc() == board[row + 3, col].GetDisc())
                    {
                        return true;
                    }
                }
            }

            // Check diagonal (positive slope)
            for (int row = 0; row < numRows - 3; row++)
            {
                for (int col = 0; col < numCols - 3; col++)
                {
                    if (board[row, col].GetDisc() != null &&
                        board[row, col].GetDisc() == board[row + 1, col + 1].GetDisc() &&
                        board[row, col].GetDisc() == board[row + 2, col + 2].GetDisc() &&
                        board[row, col].GetDisc() == board[row + 3, col + 3].GetDisc())
                    {
                        return true;
                    }
                }
            }

            // Check diagonal (negative slope)
            for (int row = 3; row < numRows; row++)
            {
                for (int col = 0; col < numCols - 3; col++)
                {
                    if (board[row, col].GetDisc() != null &&
                        board[row, col].GetDisc() == board[row - 1, col + 1].GetDisc() &&
                        board[row, col].GetDisc() == board[row - 2, col + 2].GetDisc() &&
                        board[row, col].GetDisc() == board[row - 3, col + 3].GetDisc())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        //  This is required for the board display
        public Cell[,] getBoard()
        {
            return board;
        }

    }
}


