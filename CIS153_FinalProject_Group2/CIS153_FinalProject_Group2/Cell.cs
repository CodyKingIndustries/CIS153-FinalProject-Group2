using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject_Group2
{
    internal class Cell
    {

        private int cordX;
        private int cordY;
        private string color;
        private Disc disc;

        //initialize cell with empty disc
        public Cell()
        {
            disc = null;
        }
        public Cell(int x, int y, string c)
        {
            cordX = x;
            cordY = y;
            color = c;
        }



        // Function to check if the cell is empty


        // Sets the disc in this cell to the specified disc
        public void SetDisc(Disc disc)
        {
            this.disc = disc;
        }

        public bool IsEmpty()
        {
            return disc == null;
        }
        // Returns the disc in this cell
        public Disc GetDisc()
        {
            return disc;
        }
        public int getCellCordX()
        {
            return cordX;
        }
        public int getCellCordY()
        {
            return cordY;
        }
        public string getCellColor()
        {
            return color;
        }
    }
}
