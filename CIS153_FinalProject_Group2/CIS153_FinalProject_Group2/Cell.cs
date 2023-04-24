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
 
        public Cell(int r, int c, string co)
        {
            row = r;
            col = c;
            color = co;
        }

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
