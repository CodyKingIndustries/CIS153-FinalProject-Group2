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

        //private int cordX;
        //private int cordY;
        //  This color will be moved into Disc when ready
        private string color;
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



        // Function to check if the cell is empty


        // Sets the disc in this cell to the specified disc
        public void SetDisc(Disc d)
        {
            disc = d;
        }
        //public void SetDisc(string d)
        //{
        //    disc.SetColor(d);
        //}

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
