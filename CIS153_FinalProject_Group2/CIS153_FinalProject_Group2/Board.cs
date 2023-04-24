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
        //public Board(int numRows, int numCols)
        //{
        //    board = new Cell[numRows, numCols];

        //    for (int row = 0; row < numRows; row++)
        //    {
        //        for (int col = 0; col < numCols; col++)
        //        {
        //            board[row, col] = new Cell();
        //        }
        //    }
        //}
        
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

        public bool checkWinner(int x, int y)
        {
            string color = board[x, y].getCellColor();

            // Check horizontal
            for (int c = Math.Max(0, y - 3); c <= Math.Min(numCols - 4, y); c++)
            {
                if (board[x, c].getCellColor() == color &&
                    board[x, c + 1].getCellColor() == color &&
                    board[x, c + 2].getCellColor() == color &&
                    board[x, c + 3].getCellColor() == color)
                {
                    return true;
                }
            }

            // Check vertical
            for (int r = Math.Max(0, x - 3); r <= Math.Min(numRows - 4, x); r++)
            {
                if (board[r, y].getCellColor() == color &&
                    board[r + 1, y].getCellColor() == color &&
                    board[r + 2, y].getCellColor() == color &&
                    board[r + 3, y].getCellColor() == color)
                {
                    return true;
                }
            }

            // Check diagonal \
            for (int r = Math.Max(0, x - 3); r <= Math.Min(numRows - 4, x); r++)
            {
                for (int c = Math.Max(0, y - 3); c <= Math.Min(numCols - 4, y); c++)
                {
                    if (board[r, c].getCellColor() == color &&
                        board[r + 1, c + 1].getCellColor() == color &&
                        board[r + 2, c + 2].getCellColor() == color &&
                        board[r + 3, c + 3].getCellColor() == color)
                    {
                        return true;
                    }
                }
            }

            // Check diagonal /
            for (int r = Math.Min(numRows - 1, x + 3); r >= Math.Max(3, x); r--)
            {
                for (int c = Math.Max(0, y - 3); c <= Math.Min(numCols - 4, y); c++)
                {
                    if (board[r, c].getCellColor() == color &&
                        board[r - 1, c + 1].getCellColor() == color &&
                        board[r - 2, c + 2].getCellColor() == color &&
                        board[r - 3, c + 3].getCellColor() == color)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool checkTie()
        {
            // Check if there are any empty cells left on the board
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (board[row, col].getCellColor() == "Grey")
                    {
                        // There is an empty cell, so the game is not tied
                        return false;
                    }
                }
            }

            // There are no empty cells, so the game is tied
            return true;
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
        //public bool IsColumnFull(int col)
        //{
        //    return board[0, col].GetDisc() != null;
        //}

        // Function to check if the board is full
        //public bool IsBoardFull()
        //{
        //    for (int col = 0; col < numCols; col++)
        //    {
        //        if (!IsColumnFull(col))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //  This is required for the board display
        public Cell[,] getBoard()
        {
            return board;
        }

    }
}


