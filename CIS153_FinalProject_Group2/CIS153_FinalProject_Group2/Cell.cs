using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject_Group2
{
    internal class Cell
    {
        // ========================================================================
        //  Both a Cell and a Disc Class is redundant
        //  Cell holds Disc, Disc Holds Color, Neither needs x/y cords [boards job]


        //  Thus I am transitioning to remove "cell" to ONLY have disc
        //  But am temporarily leaving the code here in comments just for temp backup
        // ========================================================================


        //  This color will be moved into Disc when ready
        private string color;
        int row;
        int col;
        private bool occupied;
        private Disc disc;

        //initialize cell with empty disc
        public Cell()
        {
            disc = null;
        }
        public Cell(string c)
        {
            color = c;
            //disc = null;
        }
        public Cell(Disc c)
        {
            //cordX = x;
            //cordY = y;
            disc = c;
        }
        public Cell(int r, int c, string co)
        {
            row = r;
            col = c;
            color = co;
        }
        //===
        //Please don't remove
        public bool isFull()
        {
            if (occupied == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void placeDisc()
        {
            occupied = true;
        }
        //====
        public int getRow()
        {
            return row;
        }
        public int getCol()
        {
            return col;
        }

        public void SetDisc(Disc d)
        {
            disc = d;
        }

        // Sets the disc in this cell to the specified disc
        //public void SetDisc(string d)
        //{
        //    disc.SetColor(d);
        //}

        // Function to check if the cell is empty
        public bool IsEmpty()
        {
            return disc == null;
        }
        // Returns the disc in this cell
        public Disc GetDisc()
        {
            return disc;
        }
        //public int getCellCordX()
        //{
        //    return cordX;
        //}
        //public int getCellCordY()
        //{
        //    return cordY;
        //}
        public void setCellColor(string c)
        {
            color = c;
        }
        public string getCellColor()
        {
            return color;
        }
    }
}
