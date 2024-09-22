using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi4
{
    class Point3D : IPoint
    {
        private double x;
        private double y;
        private double z;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Point3D(Point3D v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        public double cal_dist(IPoint v)
        {
            Point3D d = v as Point3D;
            return Math.Sqrt(Math.Pow(d.x-x,2)+Math.Pow(d.y-y,2)+Math.Pow(d.z-z,2));
        }
        public string printPoint()
        {
            return $"({x},{y},{z})";
        }
    }
}
