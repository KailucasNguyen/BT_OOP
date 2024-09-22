using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi4
{
    class Point2D : IPoint
    {
        private double x;
        private double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point2D(Point2D v)
        {
            x = v.x;
            y = v.y;
        }
        public string printPoint()
        {
            return $"({x},{y})";
        } 
        public double cal_dist(IPoint v)
        {
            Point2D j = v as Point2D;
            return Math.Sqrt(Math.Pow(j.x - x, 2) + Math.Pow(j.y - y, 2));
        }
    }
}
