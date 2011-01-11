using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoRender
{
    public class Vector3
    {
        double x;
        double y;
        double z;

        public double X { get { return x; } }
        public double Y { get { return y; } }
        public double Z { get { return z; } }

        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3 Add(Vector3 other)
        {
            return new Vector3(x + other.x, y + other.y, z + other.z);
        }

        public Vector3 Multiply(double scalar)
        {
            return new Vector3(x * scalar, y * scalar, z * scalar);
        }

        public double MultiplyVdot(Vector3 other)
        {
            double result = ((x * other.x) + (y * other.y) + (z * other.z));
            return result;
        }
    }
}
