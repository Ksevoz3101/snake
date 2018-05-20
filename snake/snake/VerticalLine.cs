﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine
    {
        List<Point> plist;

        public VerticalLine(int x, int yUp, int yDown, char sim)
        {
            plist = new List<Point>();

            for(int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y , sim);
                plist.Add(p);
            }
        }
        public void Druw()
        {
            foreach(Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
