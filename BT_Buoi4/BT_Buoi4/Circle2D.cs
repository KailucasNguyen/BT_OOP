using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi4
{
    internal class Circle2D :  ICircle
    {
        private double radius;
        private Point2D s1;

        public double Radius { get => radius; set => radius = value; }
        internal Point2D S1 { get => s1; set => s1 = value; }

        public Circle2D(Point2D s1, double radius)
        {
            this.s1 = s1;
            this.radius = radius;
        }
        public Circle2D(Circle2D c)
        {
            radius = c.Radius;
            s1 = c.S1;
        }
        public double cal_area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public string printCircle()
        {
            return $"I{s1.printPoint()} R={radius}";
        }
        public IPoint GetPoint()
        {
            return this.s1;
        }
    }
}
