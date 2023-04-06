using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject_Group2
{
    internal class Board
    {
        private Cell[,] board; // 2D array of Cells representing the game board
        private const int numRows = 6; // number of rows in the game board
        private const int numCols = 7; // number of columns in the game board
        
        // Constructor to initialize the board with empty cells
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

        // Function to place a disc in the specified column and return the row it was placed in
        public int PlaceDisc(int col, Disc disc)
        {
            int row = GetNextEmptyRow(col);
            if (row != -1)
            {
                board[row, col].SetDisc(disc);
                return row;
            }
            return -1;
        }
        public int GetNextEmptyRow(int col)
        {
            for (int row = numRows - 1; row >= 0; row--)
            {
                if (board[row, col].GetDisc() == null)
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
    }
}


