using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B2
{
    internal class Vector
    {
        private float x;
        private float y;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }

        public Vector(float x_ = 0, float y_ = 0)
        {
            x = x_;
            y = y_;
        }
        public Vector(Vector vector)
        {
            x = vector.x;
            y = vector.y;
        }

        public string printVector()
        {
            return $"({x},{y})";
        }
        public void showInfo()
        {
            Console.WriteLine(printVector());
        }
        public Vector Add(Vector v)
        { 
            return new Vector(x + v.x, y + v.y);
        }
        public Vector Subtract(Vector v)
        {
            return new Vector(x -  v.x, y - v.y);
        }
        public float Multiply(Vector v)
        {
            return x*v.x + y*v.y;
        }
        public bool orth(Vector v)
        {
            return Multiply(v) == 0;
        }
    }
}
