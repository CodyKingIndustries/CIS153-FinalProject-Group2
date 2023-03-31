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


        public Cell()
        {

        }
        public Cell(int x, int y, string c)
        {
            cordX = x;
            cordY = y;
            color = c;
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
