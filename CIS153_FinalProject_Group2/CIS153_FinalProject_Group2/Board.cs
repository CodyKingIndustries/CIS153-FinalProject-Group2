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
            Cell CreateCell = new Cell();
            
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    //  all cells are assigned the color of "Grey" becuase when calling a funciton to get the value
                    //  without a given color already established, it breaks.
                    //  thus all non used cells can be intpreted as "grey" == "null" == "un-used"
                    CreateCell = new Cell("Grey");
                    board[row, col] = CreateCell;
                }
            }

        }


        //  IN HERE IS REPURPOSED CODE - due to a change I made, this section was slightly repurposed
        //  ====================================================================================

        // Function to place a disc in the specified column and return the row it was placed in
        //public int PlaceDisc(int col, Disc disc)
        //{
        //    int row = GetNextEmptyRow(col);
        //    if (row != -1)
        //    {
        //        board[row, col].SetDisc(disc);
        //        return row;
        //    }
        //    return -1;
        //}

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


