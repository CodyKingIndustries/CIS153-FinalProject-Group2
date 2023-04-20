using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject_Group2
{
    internal class Cell
    {
        


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
        //  option to place disc and setColor
        public void placeDisc(string c)
        {
            occupied = true;
            color = c;
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
