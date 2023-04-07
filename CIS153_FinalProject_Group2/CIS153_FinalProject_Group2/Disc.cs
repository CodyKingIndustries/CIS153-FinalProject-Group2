using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject_Group2
{
    public class Disc
    {
        private string color; // color of the disc
        //  Disc Doesn't need these, that is Boards job to know
        //private int cordX;    //  x cordinate of disc
        //private int cordY;    //  y cordinate of disc

        public Disc()
        {

        }
        //public Disc(int x, int y)
        //{
            
        //    cordX = x;
        //    cordY = y;
        //}
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string getColor()
        {
            return color;
        }
        //public int getDiscCordX()
        //{
        //    return cordX;
        //}
        //public int getDiscCordY()
        //{
        //    return cordY;
        //}
        public void SetColor(string c)
        {
            color = c;
        }


    }
    
}

