using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi2
{
    class Vector2D : Vector
    {
        private float x;
        private float y;
        public float X { get { return x; } set { x = value; } }

        public float Y { get => y; set => y = value; }

        public Vector2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public Vector2D(Vector2D v)
        {
            x = v.x;
            y = v.y;
        }

        public override string ShowInfo()
        {
            return $"({x},{y})";
        }
        public override Vector Sum(Vector v)
        {
            Vector2D j = v as Vector2D;
            return new Vector2D(x + j.x,y + j.y);
        }
        public override bool Orth(Vector v)
        {
            Vector2D j = v as Vector2D;
            return x * j.x + y *j.y == 0;
        }
    }
}
