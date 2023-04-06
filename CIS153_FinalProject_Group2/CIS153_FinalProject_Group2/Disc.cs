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

        public Disc()
        {

        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string getColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }


    }
    
}

