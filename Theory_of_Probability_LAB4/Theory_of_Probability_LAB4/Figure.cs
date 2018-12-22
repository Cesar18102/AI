using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Theory_of_Probability_LAB4
{
    public class Figure
    {
        public uint DrawMode;
        public Color C;
        public List<Point> P = new List<Point>();

        public Figure(Color C, uint DrawMode)
        {
            this.C = C;
            this.DrawMode = DrawMode;
        }
    }
}
