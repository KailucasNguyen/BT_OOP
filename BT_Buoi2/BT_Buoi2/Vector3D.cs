using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi2
{
    class Vector3D : Vector
    {
        private float x;
        private float y;
        private float z;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float Z { get => z; set => z = value; }

        public Vector3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vector3D(Vector3D v)
        {
            x = v.x;
            y = v.y;
            z = v.z;
        }
        public override string ShowInfo()
        {
            return $"({x},{y},{z})";
        }
        public override Vector Sum(Vector v)
        {
            Vector3D j = v as Vector3D;
            return new Vector3D(x + j.x, y + j.y,z +j.z);
        }
        public override bool Orth(Vector v)
        {
            Vector3D j = v as Vector3D;
            return x * j.x + y * j.y + z * j.z == 0;
        }
    }
}
