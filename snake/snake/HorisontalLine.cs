using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorisontalLine : Figure
    {

        public HorisontalLine(int xLeft, int xRight, int y, char sim)
        {
            plist = new List<Point>();

            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sim);
                plist.Add(p);
            }

        }
    }
 
}
