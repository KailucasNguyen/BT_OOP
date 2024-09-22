using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi4
{
    class Circle3D : ICircle
    {
        private double radius;
        private Point3D s2;

        public double Radius { get => radius; set => radius = value; }
        internal Point3D S2 { get => s2; set => s2 = value; }

        public Circle3D(Point3D s2,double radius)
        {
            this.s2 = s2;
            this.radius = radius;
        }
        public Circle3D(Circle3D c)
        {
            s2 = c.s2;
            radius = c.Radius;
        }
        public double cal_area()
        {
            return 4*Math.PI*Math.Pow(radius,2);
        }
        public string printCircle()
        {
            return $"I{s2.printPoint()} R={radius}";
        }
        public IPoint GetPoint()
        {
            return this.s2;
        }
    }
}
