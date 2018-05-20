using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Func1(x);
            Console.WriteLine("Func1. х = " + x);

            Func2(x);
            Console.WriteLine("Func2. х = " + x);

            Func3(x);
            Console.WriteLine("Func3. х = " + x);

            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);
            Console.WriteLine("Координаты точки по х =" + p1.x + " а по у = " + p1.y);

            Point p2 = new Point(4, 5, '#');
            p1 = p2;
            p2.x = 7;
            p2.y = 7;
            Console.WriteLine("p1.x = " + p1.x + ", p1.y = " + p1.y + "and p2.x = " + p2.x + " , p2.y ="+ p2.y);

            p1 = new Point(1, 3, '*');
            Update(p1);
            Console.WriteLine("p1.x = "+ p1.x + ", p1.y = "+ p1.y);
            Console.ReadLine();
       }
        
        public static void Func1(int value)
        {
            value = value + 1;
        }
        public static void Func2(int value)
        {
            value = value + 2;
        }
        public static void Func3(int value)
        {
            value = value + 3;
        }
        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }
        public static void Update(Point p)
        {

        }

    }
}
